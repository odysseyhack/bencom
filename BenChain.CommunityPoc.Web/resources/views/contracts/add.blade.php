@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header">
                    <h3>Contract toevoegen</h3>
                </div>
                <div class="card-body">
                    <form method="post">
                        @csrf
                        <div class="form-group">
                            <label for="company"><b>Bedrijfsnaam</b></label>
                            <input type="text" id="company" class="form-control" name="company" />
                        </div>
                        <div class="form-group">
                            <label for="description"><b>Contract</b></label>
                            <textarea id="description" class="form-control" rows="10" name="description"></textarea>
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
