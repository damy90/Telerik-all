# Шаблони за дизайн домашно
## Абстрактна Фабрика
Абстрактна фабрика е създаващ шаблон за дизайн, който се използва в обектно-ориентираното програмиране.
Фабриката е средство за създаване на обекти. Целта на този шаблон за дизайн е да изолира създаването на обектите от тяхното използване.
![Абстрактна Фабрика](abstract-factory.png)
Абстрактната фабрика капсулира група от методи Фабрика имащи близко предназначение. Клиентският код създава конкретна имплементация на абстрактната фабрика, след това използва основния интерфейс за да създава конкренти обекти. Клиентът не е задължен да знае коя от тези фабрики е създала конкретния обект, защото той използва само основния интерфейс към създадените обекти.
Този шаблон позволява замяната на конкретни класове, дори по време на изпълнение, без да е нужна промяна на кода, който ги използва. Това обаче е за сметка на на допълнително усложняване на кода, което не е много желателно.
###Пример:
'''C#
abstract class GUIFactory {
     public static GUIFactory getFactory() {
         int sys = readFromConfigFile("OS_TYPE");
         if (sys==0) {
             return(new WinFactory());
         } else {
             return(new OSXFactory());
         }
    }
    public abstract Button createButton();
 }
 
 class WinFactory:GUIFactory {
     public override Button createButton() {
         return(new WinButton());
     }
 }
 
 class OSXFactory:GUIFactory {
     public override Button createButton() {
         return(new OSXButton());
     }
 }
 
 abstract class Button  {
     public string caption;
     public abstract void paint();
 }
 
 class WinButton:Button {
     public override void paint() {
        Console.WriteLine("I'm a WinButton: "+caption);
     }
 }
 
 class OSXButton:Button {
     public override void paint() {
        Console.WriteLine("I'm a OSXButton: "+caption);
     }
 }
 
 class Application {
     static void Main(string[] args) {
         GUIFactory aFactory = GUIFactory.getFactory();
         Button aButton = aFactory.createButton();
         aButton.caption = "Play";
         aButton.paint();
     }
     //output is: I'm a WinButton: Play, or: I'm a OSXButton: Play
 }
 '''