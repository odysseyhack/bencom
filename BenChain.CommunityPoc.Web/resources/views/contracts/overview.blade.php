@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header">
                    <h3>Openstaande contracten</h3>
                </div>

                <div class="card-body">
                    <a href="/contract/add" class="btn btn-primary">Contract toevoegen</a>
                    <br/><br/>
                    <table class="table" >
                        <tr>
                            <th>Bedrijf</th>
                            <th>Datum</th>
                            <th></th>
                        </tr>
                    @foreach ($contracts as $contract)
                        <tr>
                            <td>{{ $contract->company }}</td>
                            <td>{{ date('d-m-Y', strtotime($contract->created_at)) }}</td>
                            @if($contract->score === NULL)
                            <td style="width: 100px;"><a href="/contract/review/{{ $contract->id }}">Beoordelen</a></td>
                            @else
                            <td style="width: 100px;"><a href="/contract/view/{{ $contract->id }}">Inzien</a></td>
                            @endif
                        </tr>
                    @endforeach
                    </table>
                    {{ $contracts->links() }}
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
