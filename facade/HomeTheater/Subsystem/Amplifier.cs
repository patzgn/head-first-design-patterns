namespace HomeTheater.Subsystem;

public class Amplifier
{
    private readonly string _description;
    private Tuner? _tuner;
    private StreamingPlayer? _player;

    public Amplifier(string description)
    {
        _description = description;
    }

    public void On() =>
        Console.WriteLine(_description + " on");

    public void Off() =>
        Console.WriteLine(_description + " off");

    public void SetStereoSound() =>
        Console.WriteLine(_description + " stereo mode on");

    public void SetSurroundSound() =>
        Console.WriteLine(_description + " surround sound on (5 speakers, 1 subwoofer)");

    public void SetVolume(int level) =>
        Console.WriteLine(_description + " setting volume to " + level);

    public void SetTuner(Tuner tuner)
    {
        Console.WriteLine(_description + " setting tuner to " + tuner);
        _tuner = tuner;
    }

    public void SetStreamingPlayer(StreamingPlayer player)
    {
        Console.WriteLine(_description + " setting Streaming player to " + player);
        _player = player;
    }

    public override string ToString() => _description;
}
