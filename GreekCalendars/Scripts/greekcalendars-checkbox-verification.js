function viewClickVerify() {
    var total = $('input:checked').length;
    if (total == 0)
    {
        swal({
            title: "Oops...",
            text: "You must select an organization to view",
            type: "error",
            showConfirmButton: false
        });
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        setTimeout(function () {
            location.reload();
        }, 5000);

    }
    else if(total > 1)
    {
        swal({
            title: "Oops...",
            text: "You may only select one organization to view at a time",
            type: "error",
            showConfirmButton: false
        });
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        setTimeout(function () {
            location.reload();
        }, 5000);

    }
    else
    {
        window.location.href = 'Rush/CheckSubmit';
    }
}

function compareClickVerify() {
    var total = $('input:checked').length;

    if (total == 0) {
        swal({
            title: "Oops...",
            text: "You must select two organizations to compare",
            type: "error",
            showConfirmButton: false
        });
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        setTimeout(function () {
            location.reload();
        }, 5000);

    }
    else if (total == 1)
    {
        swal({
            title: "Oops...",
            text: "You must select two organizations to compare at a time",
            type: "error",
            showConfirmButton: false
        });
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        setTimeout(function () {
            location.reload();
        }, 5000);
    }
    else if (total > 2) {

        swal({
            title: "Oops...",
            text: "You may only select two organizations to compare at a time",
            type: "error",
            showConfirmButton: false
        });
        document.getElementById('form').onsubmit = function () {
            return false;
        };
        setTimeout(function () {
            location.reload();
        }, 5000);
    }
    else {
       window.location.href = 'Rush/CheckSubmit';
    }
}
