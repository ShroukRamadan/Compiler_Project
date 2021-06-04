using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Compiler_Project
{
    class Scanner
    {


        String[,] keyword = {
        {"Pattern","Class"},
        {"DerivedForm","Inheritance"},
        {"TrueFor","Condition"},
        {"Else","Else"},
        {"Ity","Integer"},
        {"Sity","SInteger"},
        {"Cwq","Character"},
        {"CwqSequence","String"},
        {"Ifity","Float"},
        {"Sifity","SFloat"},
        {"ValuesLess","Void"},
        {"Logical","Boolean"},
        {"BreakFormThis","Break"},
        {"Whatever","Loop"},
        {"RespondWith","Return"},
        {"Srap","Struct"},
        {"Scan","Switch"},
        {"Conditionof","Case"},
        {"Require","Inclusion"}

    };
      
        public void ScanToken(String fileName)
        {

            Output output = new Output();
            output.ShowDialog();


         //define stremreader to read from file
            StreamReader sR = new StreamReader(fileName+".txt");
         
            //define line to read from file char by char
        char line;
        int numberOfLine = 1;
        int numberOftoken = 1;
        //define string to save the char array and chek is keyword or any thing else 
        string str = "";
          
        line = (char) sR.Read();
      

            do
            {
                
                str = "";
                //check keyword or identifier
                if (Tokens.isAlphapet(line) || line == '_')
                {
                    str += line;
                    line = (char) sR.Read();
                    while (Tokens.isAlphapet(line) || Tokens.isDigit(line) || line == '_')
                    {

                        str += line;
                        line = (char) sR.Read();
                    }

                    for (int num = 0,col=0; num<19; num++)
                    {
                        if (str == keyword[num,col])
                        {
                            output.AddRow(numberOfLine.ToString(), str, keyword[num, 1] , numberOftoken++.ToString(),"Matched");
                            //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + keyword[num,1]);
                            str = null;
                            break;
                        }
                    }
                    if (str != null)
                    {

                        output.AddRow(numberOfLine.ToString(), str, "Identifier", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "Identifier");

                    }


                }
                //check digit
                else if (Tokens.isDigit(line))
{
                     str += line;
                     line = (char)sR.Read();
                while (Tokens.isDigit(line))
                {

                     str += line;
                     line = (char)sR.Read();
                }
                if (Tokens.isAlphapet(line) || line == '_')
                {
                   while (Tokens.isAlphapet(line) || Tokens.isDigit(line) || line == '_')
                   {

                       str += line;
                       line = (char)sR.Read();
                   }
                        output.AddRow(numberOfLine.ToString(), str, "Identifier", numberOftoken++.ToString(), "Not Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                    }
                else
                     output.AddRow(numberOfLine.ToString(), str, "const", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "const");


                }//end of check digit
                  //check Tooken Delimiter
                 else if (Tokens.isTookenDelimiter(line))
                 {
                      str += line;
                      line = (char)sR.Read();
                      output.AddRow(numberOfLine.ToString(), str, "TookenDelimiter", numberOftoken++.ToString(), "Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "TookenDelimiter");
                }
                   //check Braces
                 else if (Tokens.isBraces(line))
                 {
                      str += line;
                      line = (char)sR.Read();
                     output.AddRow(numberOfLine.ToString(), str, "Braces", numberOftoken++.ToString(), "Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "Braces");
                }
                   //check ArithmaticOperator
                 else if (Tokens.isArithmaticOperator(line))
                 {
                    str += line;
                    line = (char)sR.Read();
                     output.AddRow(numberOfLine.ToString(), str, "ArithmaticOperator", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "ArithmaticOperator");
                }
                 //check StartSympol
                 else if (Tokens.isStartSympol(line))
                 {
                    str += line;
                    line = (char)sR.Read();
                    output.AddRow(numberOfLine.ToString(), str, "StartSympol", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "StartSympol");
                }
                //check EndSympol
                 else if (Tokens.isEndSympol(line))
                 {
                     str += line;
                     line = (char)sR.Read();
                    output.AddRow(numberOfLine.ToString(), str, "EndSympol", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "EndSympol");
                }
                 //check QuatationMark
                  else if (Tokens.isQuatationMark(line))
                  {
                       str += line;
                       line = (char)sR.Read();
                     output.AddRow(numberOfLine.ToString(), str, "QuatationMark", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "QuatationMark");
                }
                  //check LineDelimiter
                  else if (Tokens.isLineDelimiter(line))
                  {
                      str += line;
                      line = (char)sR.Read();
                      output.AddRow(numberOfLine.ToString(), str, "LineDelimiter", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LineDelimiter");
                }
                 
                //check LogicalOperator
                  else if (Tokens.isLogicalOperator(line))
                  {
                      str += line;
                      line = (char)sR.Read();
                     output.AddRow(numberOfLine.ToString(), str, "LogicalOperator", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                }
                  //check "=" is assigmentOperator or relationalOperator
                  else if (line == '=')
                  {
                         str += line;
                         line = (char)sR.Read();
                         if (line == '=')
                         {
                                str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "RelationaltOperator", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
                         else
                           output.AddRow(numberOfLine.ToString(), str, "AsignmentOperator", numberOftoken++.ToString(), "Matched");
                          // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "AsignmentOperator");
                  }

//check "<" is relationalOperator
else if (line == '<')
{
    str += line;
    line = (char)sR.Read();
    if (line == '=')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "RelationaltOperator", numberOftoken++.ToString(), "Matched");
                        // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
            else
                     output.AddRow(numberOfLine.ToString(), str, "RelationaltOperator", numberOftoken++.ToString(), "Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                }
//check ">" is relationalOperator
else if (line == '>')
{
    str += line;
    line = (char)sR.Read();
    if (line == '=')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "RelationaltOperator", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationaltOperator");
                    }
    else
                        output.AddRow(numberOfLine.ToString(), str, "RelationaltOperator", numberOftoken++.ToString(), "Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                }
//check "|" is LogicalOperator
else if (line == '|')
{
    str += line;
    line = (char)sR.Read();
    if (line == '|')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "LogicalOperator", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                    }
    else
                        output.AddRow(numberOfLine.ToString(), str, "error", numberOftoken++.ToString(), "Not Matched");

                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
//check "&" is LogicalOperator
else if (line == '&')
{
    str += line;
    line = (char)sR.Read();
    if (line == '&')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "LogicalOperator", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "LogicalOperator");
                    }
    else
                        output.AddRow(numberOfLine.ToString(), str, "error", numberOftoken++.ToString(), " Not Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
//check "!" is LogicalOperator
else if (line == '!')
{
    str += line;
    line = (char)sR.Read();
    if (line == '=')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "RelationalOperator", numberOftoken++.ToString(), "Matched");
                        // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "RelationalOperator");
                    }
    else
                        output.AddRow(numberOfLine.ToString(), str, "error", numberOftoken++.ToString(), " Not Matched");
                    // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
                }
//check "-" is arithmaticOperator or comment or accesOperator 
else if (line == '-')
{
    str += line;
    line = (char)sR.Read();
    if (line == '-')
    {
        str += line; line = (char)sR.Read();
        while (line != '\r') { line = (char)sR.Read(); continue; }
                        output.AddRow(numberOfLine.ToString(), str, "comment", numberOftoken++.ToString(), "Matched");
                        // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "comment");
                    }
    else if (line == '>')
    {
        str += line; line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "AccessOperator", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "AccessOperator");
                    }
    else
                        output.AddRow(numberOfLine.ToString(), str, "ArithmaticOperator", numberOftoken++.ToString(), "Matched");
                    //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "ArithmaticOperator");
                }
//detecct last of line and spaces and ignore them
else if (line == '\r' || line == ' ') { line = (char)sR.Read(); continue; }
//detict new line                
else if (line == '\n')
{
    line = (char)sR.Read();
    numberOfLine++;
    numberOftoken = 1;
}
//check multy line comments
else if (line == '/')
{
    str += line;
    line = (char)sR.Read();
    if (line == '-')
    {
        str += line;
        line = (char)sR.Read();
                        output.AddRow(numberOfLine.ToString(), str, "StartMutiLinecomment", numberOftoken++.ToString(), "Matched");
                        //Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "StartMutiLinecomment");

                        while (line != '-' && (char)sR.Read() != '/')
         { 
                            if (line == '\n') numberOfLine++; line = (char)sR.Read(); 
          }
                        output.AddRow(numberOfLine.ToString(), str, "EndMutiLinecomment", numberOftoken++.ToString(), "Matched");
                        // Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "-/" + "\t" + "EndMutiLinecomment");
                        line = (char)sR.Read(); line = (char)sR.Read(); continue;
    }
    else
        Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + "/" + "\t" + "ArithmaticOperator");
}
else
{
    str += line; line = (char)sR.Read();
    Console.WriteLine(numberOfLine + "\t" + numberOftoken++ + "\t" + str + "\t" + "error");
}
            } while (!sR.EndOfStream) ;
        }
    }
    }
