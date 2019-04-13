@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header">
                    <h3>Contract van {{ $contract->company }} beoordelen</h3>
                </div>
                <div class="card-body">
                    <p>
                        {!! nl2br(e($contract->description)) !!}
                    </p>
                </div>

                <div class="card-body">
                    <form method="post">
                        @csrf
                        <div class="form-group">
                            <label for="company"><b>Bedrijfsnaam</b></label>
                            <input type="text" id="company" class="form-control" name="company" />
                        </div>
                        <div class="form-group">
                            <label for="description"><b>Algemene beschrijving</b></label>
                            <textarea id="description" class="form-control" rows="5" name="description"></textarea>
                        </div>
                        <div class="form-group">
                            <label for="danger"><b>Highlights</b></label>
                            <input type="text" id="highlight" class="form-control" name="highlight[]" />
                            <span class="btn btn-link" onclick="$('<input type=\'text\' style=\'margin-top:5px;\' name=\'highlight[]\' class=\'form-control\' />').insertBefore($(this));" >Toevoegen</span>
                        </div>
                        <div class="form-group">
                                <label for="danger"><b>Aandachtspunten</b></label>
                                <input type="text" id="danger" class="form-control" name="danger[]" />
                                <span class="btn btn-link" onclick="$('<input type=\'text\' style=\'margin-top:5px;\' name=\'danger[]\' class=\'form-control\' />').insertBefore($(this));" >Toevoegen</span>                            </div>
                        <div class="form-group">
                            <label for="score"><b>Beoordeling (1 = zeer onveilig, 10 = zeer veilig)</b></label>
                            <select class="form-control" name="score" id="score">
                                @for ($i = 1; $i <= 10; $i++)
                                <option value="{{$i}}">{{$i}}</option>
                                @endfor
                            </select>
                        </div>
                        <div class="form-group">
                            <input class="btn btn-primary" type="submit" value="Opslaan" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
