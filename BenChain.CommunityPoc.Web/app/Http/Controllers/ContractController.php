<?php

namespace App\Http\Controllers;

use App\Contract;
use App\ContractScore;
use Auth;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class ContractController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $contracts = DB::table('contracts')->paginate(15);
        $extendedContracts = [];
        foreach($contracts as $contract) {
            $score = ContractScore::where('contract_id', $contract->id)->first();
            $contract->score = $score;
        }

        return view('contracts.overview', ['contracts' => $contracts]);
    }

    public function view($contractId)
    {
        $contract = Contract::find($contractId);
        $contractScore = ContractScore::where('contract_id', $contractId)->first();
        $highlights = explode(";;;", $contractScore->highlight);
        $dangers = explode(";;;", $contractScore->danger);

        return view('contracts.view', [
            'contract' => $contract,
            'contractScore' => $contractScore,
            'highlights' => $highlights,
            'dangers' => $dangers
        ]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create(Request $request)
    {
        $content = $request->getContent();
        $contentDecoded = json_decode($content, true);

        $contract = new Contract();
        $contract->company = strip_tags($contentDecoded['company']);
        $contract->description = strip_tags($contentDecoded['description']);

        $contract->save();

        return response()->json("ok");
    }

    public function addForm() {
        return view('contracts.add');
    }

    public function add(Request $request) {

        $description = strip_tags($request->description);
        $company = $request->company;

        $contract = new Contract();
        $contract->company = $company;
        $contract->description = $description;

        $contract->save();

        return redirect('/contract/overview');
    }
}
