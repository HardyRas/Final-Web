window.onload = function () {

    $(document).ready(function () {

        $("#myTable").DataTable({

            "ajax":
            {

                "url": "http://localhost:51217/IkeregeWard/GetList",
                "type": "GET",
                "dataType": "json"

            },
            "columns":
            [
                { "data": "Months" },
                { "data": "Rainfall" },
                { "data": "Temperature" },
                { "data": "Al6" },
                { "data": "Al12" },
                { "data": "Al18" },
                { "data": "Al24" },
                { "data": "Ward Id" }
            ]

        }); 

        $("#myTable2").DataTable({

            "ajax":
            {

                "url": "http://localhost:51217/IkeregeWard/GetList",
                "type": "GET",
                "dataType": "json"

            },
            "columns":
                [
                    { "data": "Months" },
                    { "data": "Rainfall" },
                    { "data": "Temperature" },
                    { "data": "Al6" },
                    { "data": "Al12" },
                    { "data": "Al18" },
                    { "data": "Al24" },
                    { "data": "Ward Id" }
                ]

        });    
    });
}