using System;
using System.Linq;

namespace Games
{
  public static class Program
  {
	public static void Main()
	{
       Console.Write("Title of the Game: SEARCH IT TO BELIEVE IT\n");
       Console.Write("Created by: Pauline Luz L. Maigting\n");
       Console.Write("***************************************************\n");
       
       string[] answer = {"Chavacano","Tausug", "Waray", "Kapampangan", "Pangasinense"
                         ,"Ilocano", "Bikol", "Cebuano", "Tagalog", "Hiligaynon" ,"Maranao"
       	                  ,"Maguindanao" , "Surigaonon", "Aklanon","Sambal", "Ibanag","Ivatan"
       	                ,"Yakan", "Masbateno", "Kinaray-a", "T'boli", "Marinduqueno"
       	                ,"English", "Russian", "Mandarin", "Hindi","Arabic", "Dutch", "Korean", "Vietnamese"
       	                , "Japanese", "Persian", "Spanish", "Italian", "Turkish", "German", "Swedish"
       	                ,"French", "Thai", "Hungarian", "Portuguese", "Polish", "Nepali", "Greek"
       	                ,"Nigerian"};
       
       string answer1;
       string answer2;
       string answer3;
       string answer4;
       string answer5;
       string answer6;
       string answer7;
       string answer8;
       string answer9;
       string answer10;
       string answer11;
       string answer12;
       string answer13;
       string answer14;
       string answer15;
       string answer16;
       string answer17;
       string answer18;
       string answer19;
       string answer20;
       string answer21;
       string answer22;
       string answer23;
       string answer24;
       string answer25;
       string answer26;
       string answer27;
       string answer28;
       string answer29;
       string answer30;
       string answer31;
       string answer32;
       string answer33;
       string answer34;
       string answer35;
       string answer36;
       string answer37; 
       string answer38; 
       string answer39; 
       string answer40;
       string answer41;
       string answer42;
       string answer43;
       string answer44;
       string answer45;
       int point = 0;
       
     
       //GAME START//
       
       Console.Write("\nEnter [1] if you want the LOCAL LANGUAGES and [2] if you want the UNIVERSAL LANGUAGES.\n");
       int mode = Convert.ToInt32(Console.ReadLine());
       if(mode == 1)
       {
       Console.Write("\nLOCAL LANGUAGES\n");
       Console.Write("1.What Filipino dialect is similar to Spanish Language?\n");
       answer1 = Console.ReadLine();
       if(answer1 == answer[0])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("\nIncorrect, the correct answer is Chavacano\n");
       }
       Console.Write("2. It is language spoken in the province of Sulu in the Philippines?\n");
       answer2 = Console.ReadLine();
       if(answer2 == answer[1])
       {
       	   point +=1;
       	   Console.Write("\nCORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("\nIncorrect, the corrext answer is Tausug\n");
       }
       Console.Write("3. A Language spoken in the province of Samar, also in Eastern Visayas?\n ");
       answer3 = Console.ReadLine();
       if(answer3 == answer[2])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	  point +=0;
       	  Console.Write("INCORRECT, the correct answer is Waray\n");
       }
       Console.Write("4. What languages spoken in the province of Pampanga?\n");
       answer4 = Console.ReadLine();
       if(answer4 == answer[3])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer Kapampangan\n");
       }
       Console.Write("5. Dialect spoken in Pangasinan?\n");
       answer5= Console.ReadLine();
       if(answer5 == answer[4])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Pangasinense\n");
       }
       Console.Write("6. Language spoken in the land of Northwest Luzon such as Ilocos Sur?\n");
       answer6 = Console.ReadLine();
       if(answer6 == answer[5])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Ilocano\n");
       }
       Console.Write("7. A Dialect that spoken by Bicolanos?\n");
       answer7 = Console.ReadLine();
       if(answer7 == answer[6])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Bikol\n");
       }
       Console.Write("8. If you are in Cebu island, what dialect you should speak?\n");
       answer8 = Console.ReadLine();
       if(answer8 == answer[7])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Cebuano\n");
       }
       Console.Write("9. It is the major dialect that spoken in the Philippines?\n");
       answer9 = Console.ReadLine();
       if(answer9 == answer[8])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Tagalog\n");
       }
       Console.Write("10. Language spoken that mostly used in Western Visayas?\n");
       answer10 = Console.ReadLine();
       if(answer10 == answer[9])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Hiligayanon\n");
       }
       Console.Write("11. What dialect spoken in the province of Lanao del Sur and Lanao del Norte?\n");
       answer11 = Console.ReadLine();
       if(answer11 == answer[10])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Maranao\n");
       }
       Console.Write("12. A dialect uses and located in the west of Mindanao Island?\n");
       answer12 = Console.ReadLine();
       if(answer12 == answer[11])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Maguindanao\n");
       }
       Console.Write("13. A language spoken in the provinces of Surigao del Norte?\n ");
       answer13 = Console.ReadLine();
       if(answer13 == answer[12])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Surigaonon\n");
       }
       Console.Write("14. A language spoken in the provinces of Aklan?\n");
       answer14 = Console.ReadLine();
       if(answer14 == answer[13])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Aklanon\n");
       }
       Console.Write("15. It is uses in the Zambales, Palawan and Candelaria?\n");
       answer15 = Console.ReadLine();
       if(answer15 == answer[14])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Sambal\n");
       }
       Console.Write("16. Dialect spoken in the provinces of Cagayan, Isabela and Nueva Viscaya?\n");
       answer16 = Console.ReadLine();
       if(answer16 == answer[15])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point+=0;
       	   Console.Write("INCORRECT, the correct answer is Ibanag\n");
       }
       Console.Write("17. Language spoken of group native Batanes, Babuyan island of Northernmost Philippines?\n");
       answer17 = Console.ReadLine();
       if(answer17 == answer[16])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Ivatan\n");
       }
       Console.Write("18. It is the native language spoken in the Basilan?\n");
       answer18 = Console.ReadLine();
       if(answer18 == answer[17])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point+=0;
       	   Console.Write("INCORRECT, the correct is Yakan\n");
       }
       Console.Write("19. Dialect in the place of Masbate?\n");
       answer19 = Console.ReadLine();
       if(answer19 == answer[18])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Masbateno\n");
       }
       Console.Write("20. Lanaguge spoken in Antique, Iloilo and Panay?\n");
       answer20 = Console.ReadLine();
       if(answer20 == answer[3])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is Kinaray-a\n");
       }
       Console.Write("21. Dialect spoken in South Cotabato, Sarangani and Sultan Kudarat?\n");
       answer21 = Console.ReadLine();
       if(answer21 == answer[20])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT, the correct answer is T'boli\n");
       }
       Console.Write("22. Dialect that spoken in the province of Marinduque?\n");
       answer22 = Console.ReadLine();
       if(answer22 == answer[21])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Marinduqueno\n");
       }
       Console.Write("Total point:"+point, "\n");
       {
       }
       Console.Write("Enter [yes or 0] if you wanted to try other mode and Press [1] if you wanted to end the game\n");
       int entry= Convert.ToInt32(Console.ReadLine());
       if(entry == 0 )
       Console.Write("Yes\n");
       
       
   }
       else if (mode == 2){
       Console.Write("UNIVERSAL LANGUAGES\n");
       Console.Write("1. What language usually spoken when you are in foreign country?\n");
       answer23 = Console.ReadLine();
       if(answer23 == answer[22])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("Incorrect, the correct answer is English\n");
       }
       Console.Write("2. It is the influential language that spoken  by the Eastern European and European Countries?\n");
       answer24 = Console.ReadLine();
       if(answer24 == answer[23])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Russian\n");
       }
       Console.Write("3. A native dialect under the Chinese Language?\n");
       answer25 = Console.ReadLine();
       if(answer25 == answer[24])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Mandarin\n");
       }
       Console.Write("4. It is official language spoken in India?\n ");
       answer26 = Console.ReadLine();
       if(answer26 == answer[25])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Hindi\n");
       }
       Console.Write("5. It is the liturgical language of Islam?\n");
       answer27 = Console.ReadLine();
       if(answer27 == answer[26])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Arabic\n");
       }
       Console.Write("6. It is a West Germanic language spoken in the country of Netherlands?\n");
       answer28 = Console.ReadLine();
       if(answer28 == answer[27])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Dutch\n");
       }
       Console.Write("7. Language the we're already heard and also called 'hangul'?\n");
       answer29 = Console.ReadLine();
       if(answer29 == answer[28])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Korean\n");
       }
       Console.Write("8. A part of Astroasiatic language family that spoken in Vietnam?\n");
       answer30 = Console.ReadLine();
       if(answer30 == answer[29])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Vietnamese\n");
       }
       Console.Write("9. Language that we heard on anime?\n");
       answer31 = Console.ReadLine();
       if(answer31 == answer[30])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Japanese\n");
       }
       Console.Write("10. Indo European language spoken in Iran and Afghanistan?\n");
       answer32 = Console.ReadLine();
       if(answer32 == answer[31])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Persian\n");
       }
       Console.Write("11. It is the language spoken in Spain, Mexico and Colombia?\n");
       answer33= Console.ReadLine();
       if(answer33 == answer[32])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Spanish\n");
       }
       Console.Write("12. Language that remains uses in Rome?\n");
       answer34 = Console.ReadLine();
       if(answer34 == answer[33])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Italian\n");
       }
       Console.Write("13. Language spoken in the country of Turkey?\n");
       answer35 = Console.ReadLine();
       if(answer35 == answer[34])

       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Turkish\n");
       }
       Console.Write("14. An official language in Germany?\n");
       answer36= Console.ReadLine();
       if(answer36 == answer[35])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is German\n");
       }
       Console.Write("15. Whta language spoken in Sweden?\n");
       answer37= Console.ReadLine();
       if(answer37 == answer[36])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Swedish\n");
       }
       Console.Write("16. Language that spoken in the France?\n");  
       answer38= Console.ReadLine();
       if(answer38 == answer[37])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is French\n");
       }
       Console.Write("17. It is the language spoken in the country of Thailand?\n");
       answer39= Console.ReadLine();
       if(answer39 == answer[38])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Thai\n");
       }
       Console.Write("18. Language spokn in the countries of Hungary, Slovakia and Austria?\n");
       answer40= Console.ReadLine();
       if(answer40 == answer[39])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Hungarian\n");
       }
       Console.Write("19. Spoken by the Portugal, Brazil, Angola countries?\n");
       answer41= Console.ReadLine();
       if(answer41 == answer[40])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Portuguese\n");
       }
       Console.Write("20. It is the language spoken in Polan?\n");
       answer42= Console.ReadLine();
       if(answer42 == answer[41])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Polish\n");
       }
       Console.Write("21. Language uses in Nepal?\n");
       answer43= Console.ReadLine();
       if(answer43 == answer[42])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is Nepali\n");
       }
       Console.Write("22. Language on the land of Greece?\n");
       answer44= Console.ReadLine();
       if(answer44== answer[43])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
       	   Console.Write("INCORRECT,the correct answer is German\n");
       }
       Console.Write("23. Language on the country of Nigeria?\n");
       answer45 = Console.ReadLine();
       if(answer45 == answer[44])
       {
       	   point +=1;
       	   Console.Write("CORRECT\n");
       }
       else
       {
       	   point +=0;
           Console.Write("INCORRECT,the correct answer is Nigerian\n");
       }
       Console.Write("Total point:" +point ,"\n");
       }
       Console.Write("Press [1] if you wanted to end the game and [0] if tpu to play agin\n");
       int choose = Convert.ToInt32(Console.ReadLine());
       if( choose == 1)
       Console.Write("Thank you for playing this game!\n");
       if ( choose == 0 )
       Console.Write("Play again");
       }
   	   }
     }







  


