<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/


Auth::routes();
Route::get('/', 'HomeController@index')->name('home');

Route::post('/api/contract/create', 'ContractController@create');
Route::get('/api/contract/get-score/{hash}', 'ContractScoreController@getScoreApi');

Route::group(['middleware' => 'auth'], function () {
    Route::get('/contract/overview', 'ContractController@index');
    Route::get('/contract/view/{contractId}', 'ContractController@view');

    Route::get('/contract/add', 'ContractController@addForm');
    Route::post('/contract/add', 'ContractController@add');

    Route::get('/contract/review/{contractId}', 'ContractScoreController@createForm');
    Route::post('/contract/review/{contractId}', 'ContractScoreController@create');
});
