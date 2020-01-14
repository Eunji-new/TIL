
         var count=0; //선택한 좌석 수
         var click=0;
        function seat(seat){     
           var number=document.getElementById(seat.getAttribute('id')).getAttribute('id');
       
            if(document.getElementById(number).style.backgroundColor=='white' ){
                    document.getElementById(number).style.backgroundColor= 'red';
                    count++;
                    click++;
                       if(count>=2){ //좌석 하나 이상 선택하면
                           document.getElementById(number).style.backgroundColor= 'white' ;
                           count--;
                           alert("좌석은 하나만 지정 가능합니다.");
                       }
                }
            else if( document.getElementById(number).style.backgroundColor== 'red'){
                    
                        document.getElementById(number).style.backgroundColor= 'white' ;
                        count--;
                        click--;
                    
             }
         
        }
    function reservation_success(){
            var ischk = false;
        var coffee = document.getElementsByName("coffee[]");
        for(var i=0;i<coffee.length;i++){
            if(coffee[i].checked ==true){
                ischk = true;
                break;
            }
        }
        
        if(!ischk){
            alert("음료를 한 개 이상 선택해주세요.");
            return false;
        }
        
        var check = confirm("정말 예약하시겠습니까?")
        if(check)
           {
                alert("예약이 완료되었습니다.");
               self.close();
           }
        else{
             alert("예약이 취소되었습니다.");
        }
    }
    function cancel(){
         self.close();
    }
    