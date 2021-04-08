package exerciseWeek1;

import excersiseWeek1.ConvertIntegerToStringFormat;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class ConvertIntegerToStringFormatTest {
    ConvertIntegerToStringFormat convert;

    @Before
    public void initialize() {
        convert = new ConvertIntegerToStringFormat();
    }

    @Test
    public void testConvertIntToStringFormat(){
        final int second = 3601;
        final String actual = convert.convertToString(second);
        Assert.assertEquals(actual, "01:00:01");
    }
}
