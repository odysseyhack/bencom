<?php

namespace App\Http\Controllers;

use App\Contract;
use App\ContractScore;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class ContractScoreController extends Controller
{
    public function create(int $contractId, Request $request)
    {

        $dangers = implode(";;;", $request->danger);
        $highlights = implode(";;;", $request->highlight);

        $score = new ContractScore();
        $score->contract_id = $contractId;
        $score->description = strip_tags($request->description);
        $score->danger = strip_tags($dangers);
        $score->highlight = strip_tags($highlights);
        $score->score = (int)$request->score;
        $score->user_id = Auth::user()->id;
        $score->name = $request->company;

        $contract = Contract::find($contractId);
        $score->hash = $this->getTextHash($contract->description);

        $score->saveOrFail();

        return redirect('/contract/overview');
    }

    /**
     * Show the form for creating a new contract.
     *
     * @return \Illuminate\Http\Response
     */
    public function createForm(int $contractId)
    {
        if($this->isValidContractId($contractId)) {
            $contract = Contract::find($contractId);
            return view('contracts.review', ['contract' => $contract]);
        }

        return redirect('/contract/overview');
    }

    public function getScoreApi(string $hash) {
        $contractScore = ContractScore::where('hash', $hash)
            ->first();

        if($contractScore)
        {
            $contractScoreArr = $this->createContractScoreArr($contractScore);
            return response()->json($contractScoreArr);
        }

        return response()->json("");
    }

    private function createContractScoreArr($contractScore)
    {
        $contractScoreArr = [
            "hash" => $contractScore->hash,
            "score" => $contractScore->score,
            "company-name" => $contractScore->name,
            "description" => $contractScore->description,
            "dangers" => explode(";;;", $contractScore->danger),
            "highlights" => explode(";;;", $contractScore->highlight)
        ];

        return $contractScoreArr;
    }


    private function isValidContractId(int $contractId)
    {
        $contract = Contract::find($contractId);
        $contractScore = ContractScore::Where('contract_id', $contractId)->get();

        $isValidContract = ($contract && $contractScore->isEmpty());
        return $isValidContract;
    }

    private function getTextHash(string $text)
    {
        $text = strip_tags($text);
        $text = str_replace(" ", "", $text);

        $hash = sha1($text);
        return $hash;
    }

}
