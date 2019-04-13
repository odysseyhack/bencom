<?php

namespace Tests\Feature;

use Tests\TestCase;
use Illuminate\Foundation\Testing\WithFaker;
use Illuminate\Foundation\Testing\RefreshDatabase;

class ContractScoreTest extends TestCase
{
    public function testContractScoreApi()
    {
        $response = $this->get('/api/contract/get-score/fe4d5aa33ac9d103f821b364469c7e26b8948c08');
        $response->assertSeeText('Bencom');
    }
}
