package excersiseWeek1;
import org.json.JSONObject;
import org.json.JSONTokener;
import java.io.*;
import java.util.Iterator;


public class JSONContainsJSON {

    public boolean checkJSON() {
        String jsonFile = "/sample.json";
        InputStream is = getClass().getResourceAsStream(jsonFile);
        if (is == null) {
            throw new NullPointerException("Cannot find resource file " + jsonFile);
        }

        JSONTokener tokener = new JSONTokener(is);
        JSONObject json = new JSONObject(tokener);

        for (Iterator<String> it = json.keys(); it.hasNext(); ) {
            String key = it.next();
            if (json.get(key) instanceof JSONObject) {
                return true;
            }
        }
        return false;
    }

    public static void main(String[] args) {
        JSONContainsJSON jsonChecker = new JSONContainsJSON();
        System.out.println(jsonChecker.checkJSON());
    }
}
