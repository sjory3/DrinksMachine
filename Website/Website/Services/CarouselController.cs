namespace Website.Services
{
    public class CarouselController
    {
        int[] carouselPositions = new int[10]
        {
            0,      //Position 1
            828,    //Position 2
            1656,   //Position 3
            2484,   //Position 4
            3312,   //Position 5
            4140,   //Position 6
            4968,   //Position 7
            5796,   //Position 8
            6624,   //Position 9
            7452    //Position 10
        };

        private int carouselCurrentPosition = 0;
        private ControllerService controllerService;

        public CarouselController(ControllerService controllerService)
        {
            this.controllerService = controllerService;
        }

        public void MoveCarousel(int position)
        {
            //controllerService.sendCommand("carousel 0");
            if (position >= 0 && position < carouselPositions.Length)
            {
                // Move the carousel to the specified position
                carouselCurrentPosition = position;
            }
        }
    }
}
