namespace HexapodInterfacesProject
{
    public interface IRobot
    {
        void JointSetAngle(int servoNumber, int angle, bool useOffset);
        void ServoSetAngle(int servoNumber, int angle, bool useOffset);
    }
}
