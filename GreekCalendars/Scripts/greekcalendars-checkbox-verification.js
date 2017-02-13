function viewClickVerify() {
    var total = $('input:checked').length;
    if(total > 1)
    {
        alert("You may only select one organization to view at a time");
        document.getElementById('form').onsubmit = function () {
            return false;
        };
    }
    else
    {
        window.location.href = 'Rush/CheckSubmit';
    }
}

function compareClickVerify() {
    var total = $('input:checked').length;
    if (total != 2) {
        alert("You may only select two organizations to compare at a time");
        document.getElementById('form').onsubmit = function () {
            return false;
        };
    }
    else {
        window.location.href = 'Rush/CheckSubmit';
    }
}
