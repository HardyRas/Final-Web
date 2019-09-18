//displays the prevalence vs timeline chart
    var lineChartData =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December",],
        datasets: [
            {
                //prevalence
                label: "My First dataset",
                fillColor: "rgba(22,2,240,0.2)",
                strokeColor: "rgba(22,2,240,1)",
                pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],
            }
        ]

    }


    //displays the prevalence vs rainfall and temperature chart
    var lineChartData1 =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
            {
                //rain
                label: "My First dataset 1",
                fillColor: "rgba(0,255,128,0.2)",
                strokeColor: "rgba(0,255,128,1)",
                pointColor: "rgba(0,255,128,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(0,255,128,1)",
                data: [53.63,25.17,126.33,73.8,73.46,51.04,26.81,63.37,60.34,42.45,65.51,87.85,48.57,45.97,82.44,55.63,55.37,55.92,70.23,51.49,87.26,69.11,60.1,19.9,16.59,89.46,129.83,68.04,52.42,53.52,57.05,60.93,153.21,127.39,102.87,95.38]
            },
            {
                //temp
                label: "My Second dataset 1",
                fillColor: "rgba(255,0,0, 0.2)",
                strokeColor: "rgba(255,0,0, 1)",
                pointColor: "rgba(255,0,0, 1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(255,0,0, 1)",
                data: [19,20,19,18,17,18,18,19,19,19,19,18,19,20,19,19,18,18,18,19,19,19,18,20,21,21,19,19,18,19,20,20,21,19,19,20]
            },

            {
                  //prevalence
                label: "My First dataset",
                fillColor: "rgba(22,2,240,0.2)",
                  strokeColor: "rgba(22,2,240,1)",
                  pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#eff",
                pointHighlightFill: "#eee",
                  pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],
               }
        ]

    }



    //displays the prevalence vs al6 chart
    var lineChartData2 =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
            {
                //al6
                label: "My First dataset 2",
                fillColor: "rgba(255,0,255,0.2)",
                strokeColor: "rgba(255,0,255,1)",
                pointColor: "rgba(255,0,255,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(255,0,255,1)",
                data: [384,285,581,696,253,162,0,147,270,338,270,552,286,456,0,120,60,0,78,439,210,120,510,150,240,180,270,210,360,330,150,240,210,0,30,0]
            },
            {
                //prevalence
                label: "My First dataset",
                fillColor: "rgba(22,2,240,0.2)",
                strokeColor: "rgba(22,2,240,1)",
                pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],

            }
        ]

    }


    //displays the prevalence vs al12 chart
    var lineChartData3 =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
            {
                label: "My First dataset 3",
                fillColor: "rgba(0,0,0,0.2)",
                strokeColor: "rgba(0,0,0,1)",
                pointColor: "rgba(0,0,0,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(0,0,0,1)",
                data: [269,197,561,304,183,324,0,99,30,294,240,264,800,270,412,60,360,240,0,88,608,270,90,270,360,0,210,180,180,0,90,60,60,0,0,30/*,0,0,0,170,466,309,240,300,0,330,0,0*/]
            },
            {
                //prevalence
                label: "My First dataset",
                fillColor: "rgba(22,2,240,0.2)",
                strokeColor: "rgba(22,2,240,1)",
                pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],

            }
        ]

    }


    //displays the prevalence vs al18 chart
    var lineChartData4 =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
            {
                label: "My First dataset 4",
                fillColor: "rgba(255,192,203,0.2)",
                strokeColor: "rgba(255,192,203,1)",
                pointColor: "rgba(255,192,203,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(255,192,203,1)",
                data: [320,67,57,26,85,232,0,23,30,0,180,0,340,337,0,120,60,60,0,60,0,0,0,210,210,330,300,330,620,390,670,280,240,300,0,0]
            },
            {
                label: "My First dataset",
                fillColor: "rgba(22,2,240,0.2)",
                strokeColor: "rgba(22,2,240,1)",
                pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],

            }
        ]

    }


    //displays the prevalence vs al24 chart
    var lineChartData5 =
    {
        labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
            {
                label: "My First dataset 5",
                fillColor: "rgba(210,105,30,0.2)",
                strokeColor: "rgba(210,105,30,220,1)",
                pointColor: "rgba(210,105,30,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(210,105,30,1)",
                data: [383, 388, 575, 256, 383, 630, 0, 123, 173, 0, 240, 553, 820, 379, 90, 540, 102, 0, 102, 0, 358, 0, 240, 470,330,330,870,210,510,480,0,150,180,0,0]
            },
            {
                label: "My First dataset5",
                fillColor: "rgba(22,2,240,0.2)",
                strokeColor: "rgba(22,2,240,1)",
                pointColor: "rgba(22,2,240,1)",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(22,2,240,1)",
                data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],

            }
        ]

}



var lineChartDataAL6=
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            //al6
            label: "My First dataset 2",
            fillColor: "rgba(255,0,255,0.2)",
            strokeColor: "rgba(255,0,255,1)",
            pointColor: "rgba(255,0,255,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,255,1)",
            data: [384, 285, 581, 696, 253, 162, 0, 147, 270, 338, 270, 552, 286, 456, 0, 120, 60, 0, 78, 439, 210, 120, 510, 150, 240, 180, 270, 210, 360, 330, 150, 240, 210, 0, 30, 0]
        }
    ]

}

var lineChartDataAL12 =
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            label: "My First dataset 3",
            fillColor: "rgba(0,0,0,0.2)",
            strokeColor: "rgba(0,0,0,1)",
            pointColor: "rgba(0,0,0,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(0,0,0,1)",
            data: [269, 197, 561, 304, 183, 324, 0, 99, 30, 294, 240, 264, 800, 270, 412, 60, 360, 240, 0, 88, 608, 270, 90, 270, 360, 0, 210, 180, 180, 0, 90, 60, 60, 0, 0, 30/*,0,0,0,170,466,309,240,300,0,330,0,0*/]
        }
    ]

}

var lineChartDataAL18 =
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            label: "My First dataset 4",
            fillColor: "rgba(255,192,203,0.2)",
            strokeColor: "rgba(255,192,203,1)",
            pointColor: "rgba(255,192,203,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,192,203,1)",
            data: [320, 67, 57, 26, 85, 232, 0, 23, 30, 0, 180, 0, 340, 337, 0, 120, 60, 60, 0, 60, 0, 0, 0, 210, 210, 330, 300, 330, 620, 390, 670, 280, 240, 300, 0, 0]
        }
    ]

}

var lineChartDataAL24 =
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            label: "My First dataset 5",
            fillColor: "rgba(210,105,30,0.2)",
            strokeColor: "rgba(210,105,30,220,1)",
            pointColor: "rgba(210,105,30,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(210,105,30,1)",
            data: [383, 388, 575, 256, 383, 630, 0, 123, 173, 0, 240, 553, 820, 379, 90, 540, 102, 0, 102, 0, 358, 0, 240, 470, 330, 330, 870, 210, 510, 480, 0, 150, 180, 0, 0]
        }
    ]
}

//COOOOOOOOMMMMMMMMMOOOOOOOOOOODDDDDDDDDDDDIIIIIIIIIITTTTTTTTIIIIIIIIES
var lineChartDataGurarAL6 =
{
    labels: ["17", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "18", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            //al6 gurar
            label: "My First dataset alG",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [6, 4, 4, 3, 3, 4, 4, 6, 6, 6, 12, 0, 6, 11, 0, 3, 2, 3, 2, 2, 2, 2, 2, 6]
        },
        {
            //al6 ikerege
            label: "My First dataset alIk",
            fillColor: "rgba(255,0,255,0.2)",
            strokeColor: "rgba(255,0,255,1)",
            pointColor: "rgba(255,0,255,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,255,1)",
            data: [384, 285, 237, 240, 360, 162, 0, 147, 270, 180, 270, 247, 253, 645, 210, 137, 338, 371, 570, 78, 439, 210, 120, 510]
        },
        {
            //prevalence gurar
            label: "My First dataset pG",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14]
        },
        {
            //prevalence ikerege
            label: "My First dataset pIk",
            fillColor: "rgba(255,0,255,0.2)",
            strokeColor: "rgba(255,0,255,1)",
            pointColor: "rgba(255,0,255,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,255,1)",
            data: [445, 246, 84, 209, 398, 158, 84, 30, 146, 0, 182, 728, 278, 250, 231, 221, 326, 398, 263, 112, 69, 179, 189, 218]
        }
    ]

}

//NOMAAAAAAAAAAAA SAAAAAAAAAAANNNNNNNNNNNNNAAAAAAAAAAAAAAAAAA 
var lineChartDataGetaPVT=
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            //prevalence geta
            label: "My First dataset 4",
            fillColor: "rgba(255,192,203,0.2)",
            strokeColor: "rgba(255,192,203,1)",
            pointColor: "rgba(255,192,203,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,192,203,1)",
            data: [320, 67, 57, 26, 85, 232, 0, 23, 30, 0, 180, 0, 340, 337, 0, 120, 60, 60, 0, 60, 0, 0, 0, 210, 210, 330, 300, 330, 620, 390, 670, 280, 240, 300, 0, 0]
        },
         {
            //prevalence ikeregeWard
            label: "My First dataset",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],
        }
    ]

}


var lineChartDataGurarPVT =
{
    labels: ["17", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "18", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            //prevalence gurar
            label: "My First dataset",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14]
        },
        {
            //prevalence ikerege
            label: "My First dataset 2",
            fillColor: "rgba(255,0,255,0.2)",
            strokeColor: "rgba(255,0,255,1)",
            pointColor: "rgba(255,0,255,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,255,1)",
            data: [445, 246, 84, 209, 398, 158, 84, 30, 146, 0, 182, 728, 278, 250, 231, 221, 326, 398, 263, 112, 69, 179, 189, 218]
        }
    ]
}


var lineChartDataKakraPVT =
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [
        {
            //prevalence kakaro
            label: "My First dataset 4",
            fillColor: "rgba(255,192,203,0.2)",
            strokeColor: "rgba(255,192,203,1)",
            pointColor: "rgba(255,192,203,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,192,203,1)",
            data: [320, 67, 57, 26, 85, 232, 0, 23, 30, 0, 180, 0, 340, 337, 0, 120, 60, 60, 0, 60, 0, 0, 0, 210, 210, 330, 300, 330, 620, 390, 670, 280, 240, 300, 0, 0]
        },
        {
            //prevalence Ikerege Ward
            label: "My First dataset",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],
        }
    ]
}


//WEEEEEEEEEEEEEUUUUUUUUUUUUUUWWWWWWWWWWWWWEHHHHHHHHHHH
var lineChartDataPvRTGurar =
{
    labels: ["13", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "14", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "15", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
    datasets: [


        {
            //rain ikerege
            label: "My First dataset 1",
            fillColor: "rgba(0,255,128,0.2)",
            strokeColor: "rgba(0,255,128,1)",
            pointColor: "rgba(0,255,128,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(0,255,128,1)",
            data: [53.63, 25.17, 126.33, 73.8, 73.46, 51.04, 26.81, 63.37, 60.34, 42.45, 65.51, 87.85, 48.57, 45.97, 82.44, 55.63, 55.37, 55.92, 70.23, 51.49, 87.26, 69.11, 60.1, 19.9, 16.59, 89.46, 129.83, 68.04, 52.42, 53.52, 57.05, 60.93, 153.21, 127.39, 102.87, 95.38]
        },
        {
            //temp ikerege
            label: "My Second dataset 1",
            fillColor: "rgba(255,0,0, 0.2)",
            strokeColor: "rgba(255,0,0, 1)",
            pointColor: "rgba(255,0,0, 1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,0, 1)",
            data: [19, 20, 19, 18, 17, 18, 18, 19, 19, 19, 19, 18, 19, 20, 19, 19, 18, 18, 18, 19, 19, 19, 18, 20, 21, 21, 19, 19, 18, 19, 20, 20, 21, 19, 19, 20]
        },

        {
            //prevalence ikerege
            label: "My First dataset",
            fillColor: "rgba(22,2,240,0.2)",
            strokeColor: "rgba(22,2,240,1)",
            pointColor: "rgba(22,2,240,1)",
            pointStrokeColor: "#eff",
            pointHighlightFill: "#eee",
            pointHighlightStroke: "rgba(22,2,240,1)",
            data: [132, 235, 161, 136, 135, 158, 84, 30, 146, 0, 0, 107, 148, 98, 0, 55, 208, 187, 145, 255, 184, 136, 279, 22, 362, 0, 189, 277, 251, 166, 166, 210, 249, 0, 0, 272/*,396,250,400,205,108,354,426,258,309,36,269*/],
        },


        //other ward
        {
            //rain gurar
            label: "My First dataset 1",
            fillColor: "rgba(0,255,128,0.2)",
            strokeColor: "rgba(0,255,128,1)",
            pointColor: "rgba(0,255,128,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(0,255,128,1)",
            data: [50, 25.17, 12.3, 7.8, 73, 51, 21, 67, 64, 45, 61, 85, 47, 47, 84, 53, 55.37, 52, 70, 51, 26, 11, 61, 19, 16, 86, 13, 64, 52, 52, 55, 63, 21, 39, 87, 98]
        },
        {
            //temp gurar
            label: "My Second dataset 1",
            fillColor: "rgba(255,0,0, 0.2)",
            strokeColor: "rgba(255,0,0, 1)",
            pointColor: "rgba(255,0,0, 1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(255,0,0, 1)",
            data: [20, 21, 20, 19, 18, 17, 18, 20, 19, 18, 19, 19, 19, 21, 19, 21, 21, 18, 21, 19, 20, 20, 19, 20, 20, 20, 20, 19, 19, 19, 21, 21, 20, 19, 18, 19]
        },
        {
            //prevalence gurar
            label: "My First dataset 5",
            fillColor: "rgba(210,105,30,0.2)",
            strokeColor: "rgba(210,105,30,220,1)",
            pointColor: "rgba(210,105,30,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(210,105,30,1)",
            data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14]
        }
      

    ]


}

