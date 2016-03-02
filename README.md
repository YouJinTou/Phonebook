Функционалност:
-	Добавене на контакт;
-	Променяне на контакт;
-	Триене на контакт;
-	Запис на текущата селекция от контакти към текстови файл.

Тази функционалност е постигната чрез недотам добре написан MVP (model-view-presenter) шаблон.

Съдържание на проекта
Проект Models:
-	Съдържа основните обекти и техните интерфейси, с които боравят другите два проекта.
Проект Data:
-	Отговаря за връзката проекта Client с базата данни.
Проект Client:
-	Съдържа models (какво се показва), views (къде и как се показва) и presenters, които осъществяват връзката между двете. 
Основни недостатъци на проекта
-	Моделът в проекта Client е само един, а по принцип трябва за всеки presenter по един модел.
-	Наместо модели се ползва обектът EditableEntry, който, като един god-object, има всичко и се ползва навсякъде.
 
Тъй като EntryRepository наследява абстрактния клас GenericRepository<T>, той е задължен да имплементира  всички негоди абстрактни методи, а те от своя страна приемат T. Проблемът настъпва, защото Add методът трябва да приеме обект с четири полета, но на Edit метода например му е нужен обект с осем – четири за старите стойности и четири за новите.
Имам някакви идеи как може да се разреши проблемът, но те са само на теория.
-	След всяко добавяне/промяна трябва да се опреснява таблицата, за да се видят промените. Опитах се да запиша Parent View-то към определени събития в Child View-тата, за да може да се опреснява автоматично, но не ми се получи. 
-	Проектът няма валидации. Ако трябваше да се напишат, бих добавил нов клас в проекта Data, отговарящ за валидирането на входящите данни.
-	Четенето на данни от файл е направено само на ниво скелет, където като коментари съм описал какви стъпки бих предприел, за да го внедря.
-	На места в Code Behind-а на  View-тата мисля, че има tight coupling.
