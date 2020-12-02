function openForm() {
    document.getElementById("myForm").style.display = "block";
    document.getElementById("btn_Popup").style.display = "none";
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    document.getElementById("btn_Popup").style.display = "block";
}
function BotChat_Post(text) {
    $.ajax({
        url: "/XemHocPhi/botChat_Post/",
        data: JSON.stringify({ strText: text }),
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $("#textArea_Popup").append('<div class= "row msg_container base_receive" >' +
                '<div class="col-md-10 col-xs-10">' +
                ' <div class="messages msg_receive">' +
                '<p style="float:left">' + result + '</p>' +

                '</div>' +
                '</div>' +

                '</div >'
            )
            $('#textArea_Popup').animate({ scrollTop: $('#textArea_Popup').prop("scrollHeight") }, 500);
        },
        error: function (errormessage) {
            
        }
    });

};

$(document).ready(function () {
    $("#btn-chat").click(function () {
        var text = $('#btn-input').val();
        if (text.length > 0) {
            BotChat_Post(text);
            $("#textArea_Popup").append('<div class= "row msg_container base_sent" >' +
                '<div class="col-md-10 col-xs-10">' +
                ' <div class="messages msg_sent">' +
                '<p style="float:right">' + text + '</p>' +

                '</div>' +
                '</div>' +

                '</div >'
            )
            $('#textArea_Popup').animate({ scrollTop: $('#textArea_Popup').prop("scrollHeight") }, 500);
            $('#btn-input').val('');


        } else {
            alert("Vui Lòng Nhập Tin Nhắn !");
        }

    })
})
