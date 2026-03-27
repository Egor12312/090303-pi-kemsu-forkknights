using System.Collections.Generic;

namespace ForkKnights.Group1 {
  public class Baklanova : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string BreathingStyle;
    public double IllusionPower;
    public double PerceptionRadius;
    public int CalmnessLevel;
    public int SwordSharpness;
    public int MentalFatigue;
    public List<string> DefeatedDemonsList;

    public Baklanova() {
      Archetype = "Corpse Illusionist";
      Name = "Haruto Tenmei";
      BreathingStyle = "Illusion Breathing";
      IllusionPower = 94.7;
      PerceptionRadius = 150.5;
      CalmnessLevel = 83;
      SwordSharpness = 100;
      MentalFatigue = 0;

      DefeatedDemonsList = new List<string> { "Kibutsu the Mirage", "Rokuro the Six-Eyed", "Yume the Dream Eater" };
      DefeatedDemonsList.Add("Phantom Demon from Shinano Province");
      DefeatedDemonsList.Add("Eleven Hallucinations of the Hell Gate");
    }

    public string GetJobApplication() {
      string JobApplicationText =
      ;


      return JobApplicationText;
    }
  }
}
