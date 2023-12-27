// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const ctx = document.getElementById('chart1');

new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['10/11', '11/11', '12/11', '13/11', '14/11', '15/11', '16/11', '17/11', '18/11', '19/11', '20/11', '21/11', '22/11', '23/11', '24/11', '25/11', '26/11'],
        datasets: [{
            label: 'BTC',
            data: [32, 38, 42, 59, 37.267, 64.267, 73.056, 81.095, 83, 76, 74, 82, 92, 86, 76, 79, 82, 84],
            borderWidth: 3,
            borderColor: '#ba54f5'
        }]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        tension: 0.5,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

const ctx2 = document.getElementById('chart2');

const data = {
    labels: [
        'Btc',
        'ADA',
        'BNB',
        'XRP',
        'ETH'
    ],
    datasets: [{
        label: '',
        data: [27, 20, 18, 12, 11],
        backgroundColor: [
            'rgb(255, 99, 132)',
            'rgb(75, 192, 192)',
            'rgb(255, 205, 86)',
            'rgb(201, 203, 207)',
            'rgb(54, 162, 235)'
        ]
    }]
};

new Chart(ctx2, {
    type: 'polarArea',
    data: data,
    options: {
        responsive: true,
        maintainAspectRatio: false
    }
});

$(document).ready(function () {
    hostName = location.hostname;
    updatePage();
    window.setInterval(updatePage, 1000);
});

function updatePage() {
    $.get(`http://${hostName}:5000/gateway/dashboard`, function (data) {
        var tableBody = "";
        var count = 0;
        for (var crypto in data) {           

                tableBody +=
                    `<tr class="TableRows" >
                    <td>${count}</td>
                        <td > ${crypto} </td>
                        <td>$ ${data[crypto][0]} </td>
                        <td>$ ${data[crypto][1]} </td>
                        <td>$ ${data[crypto][2]} </td>
                        <td>${data[crypto][3]} </td>
                    </tr>`;
            count++;
            
        }

        

        $("#dashboardTable").html(tableBody);
    });
}

