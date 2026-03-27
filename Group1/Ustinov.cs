using System;

namespace ForkKnights.Group1 {
  public class MagicArcher : IKnight {
    public string name;
    public string realm;
    public int arrowCount;
    public string magicElement;
    public int experienceYears;
    public string battleCry;
    public string favoriteWeapon;

    public MagicArcher() {
      name = "Лесной Страж Элвин";
      realm = "Зачарованного леса";
      arrowCount = 999;
      magicElement = "природной магией";
      experienceYears = 200;
      battleCry = "За честь и справедливость";
      favoriteWeapon = "Лук Ивы";
    }

    public string GetJobApplication() {
      return "\nПРИВЕТСТВИЕ ОТ ХРАНИТЕЛЯ ЛЕСА!\n\n" +
             "Я " + name + " из " + realm + ".\n\n" +
             "Обо мне:\n" +
             "- Владею " + magicElement + "\n" +
             "- Имею " + arrowCount + " магических стрел\n" +
             "- Живу в лесу " + experienceYears + " лет\n" +
             "- Любимое оружие: " + favoriteWeapon + "\n\n" +
             "Мой девиз:\n" +
             battleCry + "\n\n" +
             "Всегда рад помочь путникам и защитить лес от зла.\n" +
             "Могу научить обращению с луком и рассказать легенды древнего леса.\n\n" +
             "До встречи в лесу!\n" +
             name;
    }
  }
}