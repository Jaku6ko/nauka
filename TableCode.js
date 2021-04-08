function Add(){
    var Name = $('#Name').val();
    var Author = $('#Author').val();
    var ReleaseDate = $('#ReleaseDate').val();
    var id = GetRowId();
    $('#table-content').append(
        $('<div class="row main-row" id="row-'+id+'">').append(
            $('<div class="col-3">').append(
                $('<div class="row">').append(
                    $('<input class="form-control col-10" id="row-name-'+id+'" value="'+Name+'" disabled />')
                )
            )
        ).append (
            $('<div class="col-3">').append(
                $('<div class="row">').append(
                    $('<input class="form-control col-10" id="row-author-'+id+'" value="'+Author+'" disabled />')
                )
            )
        ).append(
            $('<div class="col-3">').append(
                $('<div class="row">').append(
                    $('<input class="form-control col-10" id="row-releasedate-'+id+'" value="'+ReleaseDate+'" disabled />')
                )
            )
        ).append(
            $('<div class="col-3">').append(
                $('<div class="row">').append(
                    $('<button id="row-edit-'+id+'" class="btn-warning" onclick="Edit('+id+')" editing=false >Edit</button>')

                ).append(
                    $('<button id="row-delete-'+id+'" class="btn-danger" onclick="Delete('+id+')"  >Delete</button>')
                )
            )
        )
    )
}

function GetNameInput(id){
    return $('#row-name-' + id);
}

function GetAuthorInput(id){
    return $('#row-author-' + id);
}

function GetReleaseDateInput(id){
    return $('#row-releasedate-' + id);
}

function EditButton(id){
    return $('#row-edit-' + id);
}

function GetRowId(){
    var Table = $('#Table');
    var count = Table.children().length;
    var id = count + 1;

    while(GetRow(id)[0] != null)
    {
        id++;
    } return id;
}

function GetRow(id){
    return $('#row-'+id);
}

function Edit(id){
    var editButton = EditButton(id);
    if(editButton.attr('editing') == "true"){
        editButton.attr('editing', false);
        editButton.text('Edit');
        Disable(GetNameInput(id));
        Disable(GetAuthorInput(id));
        Disable(GetReleaseDateInput(id));
    }else{
        editButton.attr('editing', true);
        editButton.text('Save');
        Enable(GetNameInput(id));
        Enable(GetAuthorInput(id));
        Enable(GetReleaseDateInput(id));
    }
}

function Delete(id){
    GetRow(id).remove();
}

function Disable(element){
    element.attr('disabled', true);
}

function Enable(element){
    element.attr('disabled', false);
}
