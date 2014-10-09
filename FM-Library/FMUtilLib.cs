using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_Library
{
    public class FMUtilLib
    {
        public FMUtilLib()
    
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger( typeof( FMUtilLib ) );           
 
            log.Debug( "Sample Debug Log Entry" );
            log.Info( "Sample Info Log Entry" );
            log.Warn( "Sample Warning Log ENtry" );
            log.Error( "Sample Error Log Entry" );
            log.Fatal( "Sample Fatal Log Entry" );
            
            Console.ReadLine();  // so you can read the output
        }
      
        public int addTwo(int a1, int a2)
        {
            return (a1 + a2);
        }  
    }
}
