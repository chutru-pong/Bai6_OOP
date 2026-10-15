//Ngô Trường Phúc 202418964
namespace DeviceManagement
{
    public interface IBorrower
    {
        string BorrowerId { get; }
        string FullName { get; }
        int GetMaximumDevices();
    }
}
