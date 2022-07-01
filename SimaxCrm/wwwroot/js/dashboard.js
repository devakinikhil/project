function openLeadPage(page) {
    window.location.href = "/View/Leads/" + page
}

function openInvoicePage(status) {
    window.location.href = "/Invoice/Index?leadId=0&orderStatus=" + status
}


var lineChart = new Chart($('#canvas-1'), {
    type: 'line',
    data: {
        labels: canvas_label_1,
        datasets: [{
            label: 'Invoices Revenue',
            backgroundColor: 'rgba(220, 220, 220, 0.2)',
            borderColor: 'rgba(220, 220, 220, 1)',
            pointBackgroundColor: 'rgba(220, 220, 220, 1)',
            pointBorderColor: '#fff',
            data: canvas_data_1
        }]
    },
    options: {
        responsive: true
    }
}); // eslint-disable-next-line no-unused-vars

var pieChart = new Chart($('#canvas-5'), {
    type: 'pie',
    data: {
        labels: canvas_label_2,
        datasets: [{
            data: canvas_data_2,
            backgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#c40062', '#379457', '#0dd9d9'],
            hoverBackgroundColor: ['#FF6384', '#36A2EB', '#FFCE56', '#c40062', '#379457', '#0dd9d9']
        }]
    },
    options: {
        responsive: true
    }
}); // eslint-disable-next-line no-unused-vars
