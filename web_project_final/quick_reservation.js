
    function seoultech_ediya(){
        var url="seoultech_ediya.html";
        window.open(url,"","width=600, height=600,left=300");
    }
    
    function map_change_seoul(){
        var seoul= document.getElementsByClassName("seoul_map");
        seoul_map.style.backgroundImage="url(seoul_map.gif)"
           for(var i=0; i<1; i++){
               document.getElementById("nosee").style.visibility ="hidden";
           }
    }
    function map_change_gg(){
        var seoul= document.getElementsByClassName("seoul_map");
        seoul_map.style.backgroundImage="url(gg.png)"
           for(var i=0; i<1; i++){
               document.getElementById("nosee").style.visibility ="hidden";
           }
    }
           
    function map_change_nowon(){
        var seoul= document.getElementsByClassName("seoul_map");
        seoul_map.style.backgroundImage="url(nowon_map.png)"
        document.getElementById("nosee").style.visibility ="visible";
    }
        
 function seoul(){
     document.getElementById("seoull").style.visibility="visible";
     document.getElementById("seoull").style.zIndex++;
  
 } 
    function gg(){
     document.getElementById("ggg").style.visibility="visible";
        document.getElementById("ggg").style.zIndex++;
 } 
  