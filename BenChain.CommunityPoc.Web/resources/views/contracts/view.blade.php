@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header">
                    <h3>Contract van {{ $contract->company }}</h3>
                </div>
                <div class="card-body">
                    <p>
                        {!! nl2br(e($contract->description)) !!}
                    </p>
                </div>
            </div>
            <br/>
            <div class="card">
                <div class="card-body">
                    <label><b>Beoordeeld door:</b></label>
                    <p>
                        {{$contractScore->name }}
                    </p>
                    <label><b>Beschrijving</b></label>
                    <p>
                        {!! nl2br(e($contractScore->description)) !!}
                    </p>
                    <label><b>Highlights</b></label>
                    <ul>
                    @foreach($highlights as $highlight)
                        <li>{{ $highlight }}</li>
                    @endforeach
                    </ul>
                    <label><b>Gevaren</b></label>
                    <ul>
                    @foreach($dangers as $danger)
                        <li>{{ $danger }}</li>
                    @endforeach
                    </ul>
                    <label><b>Eindoordeel</b></label>
                    <p>
                        {{$contractScore->score}}
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
