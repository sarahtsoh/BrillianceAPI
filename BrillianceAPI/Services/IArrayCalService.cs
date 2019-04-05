namespace BrillianceAPI.Services
{
    public interface IArrayCalService
    {
        int[] DeletePartArray(int position, int[] inputArray);
        int[] ReverseArray(int[] inputArray);
    }
}