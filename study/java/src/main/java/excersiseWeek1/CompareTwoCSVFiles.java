package excersiseWeek1;

import java.io.*;
import java.util.ArrayList;
import java.util.HashMap;

public class CompareTwoCSVFiles {

    public boolean compareFiles(String csv1, String csv2) throws IOException {

        BufferedReader file1 = new BufferedReader(new InputStreamReader(getClass().getResourceAsStream(csv1)));
        BufferedReader file2 = new BufferedReader(new InputStreamReader(getClass().getResourceAsStream(csv2)));

        HashMap<String,String> list1 = new HashMap<String,String>();
        HashMap<String,String> list2 = new HashMap<String,String>();

        String rowFile1 = file1.readLine();
        String rowFile2 = file2.readLine();

        while (rowFile1 != null)
        {
            String[] dataArray1 = rowFile1.split(",");
            for (int i=0;i<dataArray1.length;i++)
            {
                list1.put(dataArray1[0], dataArray1[1]);
            }

            rowFile1 = file1.readLine();
        }

        file1.close();

        while (rowFile2 != null)
        {
            String[] dataArray2 = rowFile2.split(",");
            for (int i=0;i<dataArray2.length;i++)
            {
                list2.put(dataArray2[0], dataArray2[1]);
            }

            rowFile2 = file2.readLine();
        }

        file2.close();

       return (list1.equals(list2));
    }

}

