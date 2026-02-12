using Xunit;

public class CaesarCipherTests
{
   
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Transform_LeavesNonLettersUntouched()
    {
        var result = CaesarCipher.Transform("123-!?", 5);

        Assert.Equal("123-!?", result);
    }

    [Fact]
    public void Decrypt_ReversesEncrypt()
   
}
