$(function(){
   
    
    //confirmation when click
    $('.confirmation').on('click',function(){
        var confirmation = confirm('Desea eliminar el usuario');
        if(confirmation){
            return true;   
        }
        return false;
    });
    
  
});

function remBook(id)
{

    // Peticiones Ajax : Peticiones asincronas a un archivo php
    $.ajax({
    		type: "POST",
    		url: "../x-fn.php",
    		data:  "obj=" + id,
    		cache: false,
    		success: function (result){ 
                 
                 //alert("Se quito el libro : " + result ); 
                 window.location = "c-lista_usuario.php";             
    		}
    	});

        alert(obj);
}



