namespace TodoCleanArch.States
{
    public class SharedStateService
    {
        public bool Loading { get; set; } = false;


        public void TurnOnLoading()
        {
            Loading = true;
        }

        public void TurnOffLoading()
        {
            Loading = false;
        }
    }
}
