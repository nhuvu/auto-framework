package excersiseWeek1;

public class ConvertIntegerToStringFormat {
     int second;

    public  int convertToHour(){
        return second / 3600;
    }

    public  int convertToSecond(){
        return second % 3600;
    }

    public  int convertToMinutes(){
        if((second % 3600) > 59){
            return (second % 3600) / 60;
        }
        return 0;
    }


    public  String convertToString(int sec){
        this.second = sec;
        return String.format("%02d:%02d:%02d",convertToHour(), convertToMinutes(), convertToSecond());

    }

}
