function ajaxCall(endpoint, type, param, callback) {
    $(".ajax-loader").show();
    $.ajax({
        url: window.location.origin + endpoint,
        data: param,
        dataType: 'json',
        type: type,
        success: function (data) {
            $(".ajax-loader").hide();
            callback(data)
        },
        error: function (err) {
            $(".ajax-loader").hide();
        }
    })
}

var lms = {
    dropdown: {
        getCourseChapterByCourseId: function (courseId) {
            var param = { courseId };
            $("#ChapterId").html('<option value=""></option>');
            ajaxCall("/Admin/CourseChapterContent/GetCourseChapterByCourseId", "GET", param, (data) => {
                if (data) {
                    $.each(data, function (index, item) {
                        $("#ChapterId").append('<option value="' + item.id + '">' + item.name + '</option>');
                    });
                }
            });
        }
    }
}