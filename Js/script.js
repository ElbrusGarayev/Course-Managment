// JScript File
//Generating Pop-up Print Preview page
function getPrint(print_area)
   {
   //Creating new page
   var pp = window.open();
   //Adding HTML opening tag with <HEAD> … </HEAD> portion
    pp.document.writeln('<HTML><HEAD><title>Print Preview</title>')
    pp.document.writeln('<LINK href=Styles.css type="text/css" rel="stylesheet">')
    pp.document.writeln('<LINK href=PrintStyle.css type="text/css" rel="stylesheet" media="print">')
    pp.document.writeln('<base target="_self"></HEAD>')
    
    //Adding Body Tag
    pp.document.writeln('<body MS_POSITIONING="GridLayout" bottomMargin="0"');
    pp.document.writeln('leftMargin="0" topMargin="0" rightMargin="0">');
    
    //Adding form Tag
    pp.document.writeln('<form method="post">');
    
    //Creating two buttons Print and Close within a HTML table
    pp.document.writeln('<TABLE width=100%><TR><TD></TD></TR><TR><TD align=right>');
    pp.document.writeln('</TD></TR><TR><TD>');
    
    pp.document.writeln('<INPUT ID="PRINT" type="button" value="Print" ');
    pp.document.writeln('onclick="javascript:location.reload(true);window.print();">');
    pp.document.writeln('<INPUT ID="CLOSE" type="button" value="Close" onclick="window.close();">');
    pp.document.writeln('</TD></TR></TABLE>');
    
    //Writing print area of the calling page
    pp.document.writeln(document.getElementById(print_area).innerHTML);
    //Ending Tag of </form>, </body> and </HTML>
    pp.document.writeln('</form></body></HTML>'); } 

