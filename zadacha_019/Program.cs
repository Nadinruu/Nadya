int inpnumber =12321;
       int number =inpnumber;
       int sum=0;
       int i=0;
       while(number>i){
           int num2=number%10;
           sum=num2*10+sum;
           i++;
       }
        sum/=10;
        if (inpnumber!=sum){
            Console.WriteLine ($"{inpnumber}->Нет");
        }
        else {
            Console.WriteLine ($"{inpnumber}->Да");
        }