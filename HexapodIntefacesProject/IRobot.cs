namespace HexapodInterfacesProject
{
    public interface IRobot
    {
        void SetAngle(int servoNumber, int angle, bool useOffset);
        void SetTibiaAngle(int legID, int angle);
        void SetFemurAngle(int legID, int angle);
        void SetCoxaAngle(int legID, int angle);
        void SetAllTibiaAngle(int angle);
        void SetAllFemurAngle(int angle);
        void SetAllCoxaAngle(int angle);
    }
}
