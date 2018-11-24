namespace ProjectDomain.Interfaces.Services.Specific
{
    public interface IHash
    {
        string GenerateHash(string password);
        bool CheckHash(string password, string passwordRecorded);
    }
}
