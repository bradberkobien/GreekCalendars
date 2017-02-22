function viewClickVerify() {
    var total = $('input:checked').length;
    if(total > 1)
    {
        swal("You may only select one organization to view at a time");
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        location.reload();
    }
    else
    {
        window.location.href = 'Rush/CheckSubmit';
    }
}

function compareClickVerify() {
    var total = $('input:checked').length;
    if (total == 1)
    {
        swal("You must select two organizations to compare at a time");
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        location.reload();
    }
    else if (total > 2) {
        swal("You may only select two organizations to compare at a time");
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        location.reload();
    }
    else {
       window.location.href = 'Rush/CheckSubmit';
    }
}
