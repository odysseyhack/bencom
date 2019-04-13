<?php

namespace Tests\Feature;

use Tests\TestCase;
use Illuminate\Foundation\Testing\WithFaker;
use Illuminate\Foundation\Testing\RefreshDatabase;

class ContractTest extends TestCase
{
    /**
     * Test the default overview view
     */
    public function testContractOverview()
    {
        $user = factory(\App\User::class)->create();

        $response = $this->actingAs($user)->get('/contract/overview');
        $response->assertStatus(200);
    }

    public function testContractView()
    {
        $user = factory(\App\User::class)->create();

        $response = $this->actingAs($user)->get('/contract/view/3');
        $response->assertSeeText("Contract van");
    }

}
