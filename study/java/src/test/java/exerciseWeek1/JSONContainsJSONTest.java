package exerciseWeek1;

import excersiseWeek1.JSONContainsJSON;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.io.IOException;

public class JSONContainsJSONTest {
    JSONContainsJSON jsonChecker;

    @Before
    public void innitialize(){
        jsonChecker = new JSONContainsJSON();
    }

    @Test
    public void FileContainsJsonReturnTrue() throws IOException {
        final boolean actual = jsonChecker.checkJSON("/containsJson.json");
        Assert.assertTrue(actual);
    }

    @Test
    public void FileNotContainJsonReturnFalse() throws IOException {
        final boolean actual = jsonChecker.checkJSON("/notContainsJson.json");
        Assert.assertFalse(actual);
    }

}
