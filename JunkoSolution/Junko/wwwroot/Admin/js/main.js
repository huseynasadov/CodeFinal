﻿$(document).ready(function () {
    String.prototype.removeAcento = function () {
        var text = this.toLowerCase();
        text = text.replace(new RegExp('[ÁÀÂÃ]', 'gi'), 'a');
        text = text.replace(new RegExp('[ÉÈÊ]', 'gi'), 'e');
        text = text.replace(new RegExp('[ÍÌÎ]', 'gi'), 'i');
        text = text.replace(new RegExp('[ÓÒÔÕÖ]', 'gi'), 'o');
        text = text.replace(new RegExp('[ÚÙÛÜ]', 'gi'), 'u');
        text = text.replace(new RegExp('[Ç]', 'gi'), 'c');
        text = text.replace(new RegExp('[Ə]', 'gi'), 'e');
        text = text.replace(new RegExp('[Ş]', 'gi'), 's');
        return text;
    };

    String.prototype.slugify = function () {
        return this.toString().toLowerCase().removeAcento().trim()
            .replace(/\s+/g, '-') // Replace spaces with -
            .replace(/[^\w\-]+/g, '') // Remove all non-word chars
            .replace(/\-\-+/g, '-') // Replace multiple - with single -
            .replace(/^-+/, '') // Trim - from start of text
            .replace(/-+$/, ''); // Trim - from end of text
    };

    $(".slug-source").blur(function () {
        $(".slug").val($(this).val().slugify());
    });

    $(".jobDelete").click(function (event) {
        var deletinput = this;
        event.preventDefault();
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    url: "https://localhost:44399/" + $(deletinput).attr("href"),
                    success: function () {
                        Swal.fire(
                            'Deleted!',
                            'Your file has been deleted.',
                            'success'
                        ).then(() => {
                            location.reload()
                        })
                    }
                })
            }
        })
    })


    $(".statusActive").click(function (event) {
        event.preventDefault();
        var span = this;
        $.get($(span).attr("href"), {}, function (data) {
            if (data) {
                location.reload();
            }
        });
    });
})

function readURL(input) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();
        reader.onload = function (e) {
            $("img.imgpreview").attr("src", e.target.result).width(120).height(120);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

$(function () {
    $(".categoryDelete").click(function (event) {
        var deletinput = this;
        event.preventDefault();
        Swal.fire({
            title: 'Əminsinizmi ?',
            text: "Geri qaytarmaq mümkün olmayacaq",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Bəli, silinsin!',
            cancelButtonText: 'Xeyir'
        }).then((result) => {
            if (result.value) {

                $.ajax({
                    url: $(deletinput).attr("href"),
                    success: function () {

                    },

                    complete: function () {
                        location.reload();
                        setTimeout(1000);
                    }
                })
                toastr.success('Ugurla basa catdi', 'Silindi')
            }
        })
    })
})