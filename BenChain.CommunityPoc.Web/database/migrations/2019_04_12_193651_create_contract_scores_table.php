<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateContractScoresTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('contract_scores', function (Blueprint $table) {
            $table->bigIncrements('id');
            $table->timestamps();
            $table->integer('contract_id')->unsigned();
            $table->string('hash');
            $table->string('name');
            $table->integer('user_id')->unsigned();
            $table->integer('score');
            $table->longText('description');
            $table->string('danger');
            $table->string('highlight');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('contract_scores');
    }
}
