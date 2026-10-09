using System;

class ImagningActivity : Activity
{
    public ImagningActivity() 
    : base("Imagining Activity", "This activity will help you feel calm by imagining peaceful senarios.")
    {
        
    }

    List<string> _senarios = ["Picture yourself sitting safely inside a dry, rustic cabin, looking out a large window at a lush forest. You listen to the soft, rhythmic patter of rain tapping against the glass and leaves. You feel completely warm, secure, and at ease as the earth drinks in the water.",
                              "Imagine standing barefoot on a secluded beach at sunset, where the wet sand molds perfectly to your feet. You watch the small, crystal-clear waves gently roll onto the shore and recede. Your breathing naturally matches the steady, soothing rhythm of the tide.",
                              "Picture yourself walking slowly through a sun-drenched alpine meadow filled with wildflowers. A cool, gentle breeze brushes against your skin, carrying the faint, sweet scent of pine and lavender. You feel completely unhurried, with nothing to do but enjoy the quiet space.",
                              "Imagine curling up in a plush, comfortable armchair in a dimly lit room, wrapped in your favorite soft blanket. A fireplace crackles softly in front of you, casting a warm, amber glow across the room. You watch the flames dance and change shape, feeling deeply anchored and still.",
                              "Picture yourself resting on a comfortable blanket in an open field, far away from city lights on a clear, crisp night. You look up at the vast blanket of stars shimmering silently in the dark. The immense space above fills you with a deep sense of quiet perspective and wonder.",
                              "Picture yourself strolling down a quiet, tree-lined path in the late afternoon. Golden sunlight filters through the canopy, lighting up vibrant red and orange leaves. With every slow step, you listen to the satisfying, soft crunch of leaves beneath your feet, feeling grounded and present.",
                              "Imagine stepping inside a warm, glass greenhouse filled with thousands of vibrant green ferns and exotic plants. The air is rich with the earthy scent of fresh soil and blooming jasmine. You sit down on a smooth stone bench, listening to the soft, rhythmic hum of a small water fountain nearby as the outside world fades away."];

    private void ImagineDescriptions(int duration)
    {
        // imagine the following senario
        Console.WriteLine("Imagine the following senario:");

        //random senario with spinner for duration seconds
        CountdownSpinner($"--- {RandomStringFromList(_senarios)} ---", GetDuration(), "next");
        Console.WriteLine();

        //ask how it made them feel and allow input
        Console.WriteLine("How did imagining this make you feel?");
        Console.Write(">");
        Console.ReadLine();
    }

    public void RunImaginingActivity()
    {
        Run(ImagineDescriptions);
    }
}