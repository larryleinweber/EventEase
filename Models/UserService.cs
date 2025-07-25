public class UserService
{
    private readonly List<UserInfo> _userRecords = new();

    public void AddUser(UserInfo user)
    {
        _userRecords.Add(user);
    }

    public IEnumerable<UserInfo> GetAllUsers()
    {
        return _userRecords;
    }

}
