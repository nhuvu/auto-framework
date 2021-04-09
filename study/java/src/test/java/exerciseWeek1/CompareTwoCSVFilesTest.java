package exerciseWeek1;

import excersiseWeek1.CompareTwoCSVFiles;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.io.IOException;

public class CompareTwoCSVFilesTest {
    CompareTwoCSVFiles compareChecker;

    @Before
    public void initialize() {
        compareChecker = new CompareTwoCSVFiles();
    }

    @Test
    public void TwoSimilarFilesReturnTrue() throws IOException {
        final boolean actual = compareChecker.compareFiles("/file1.csv", "/file2.csv");
        Assert.assertTrue(actual);
    }

    @Test
    public void TwoDifferentFilesReturnFalse() throws IOException {
        final boolean actual = compareChecker.compareFiles("/file1.csv", "/file3.csv");
        Assert.assertFalse(actual);
    }

}
