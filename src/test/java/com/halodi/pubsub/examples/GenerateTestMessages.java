package com.halodi.pubsub.examples;

import us.ihmc.commons.nio.FileTools;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Arrays;

import com.halodi.idl.generator.IDLCSharpGenerator;

public class GenerateTestMessages
{
   /**
    * Must be run from ihmc-pub-sub-group/ihmc-pub-sub-generator/src/test folder.
    */
   public static void main(String[] args) throws IOException
   {
      FileTools.deleteQuietly(Paths.get("generated-java"));

      /**
       * Generate Java types for all (*.idl) file in `src/test/idl` and put them in `src/test/generated-java`.
       */
      for (Path idl : Files.list(Paths.get("idl")).toArray(Path[]::new))
      {
         IDLCSharpGenerator.execute(idl.toFile(),
                              "",
                              Paths.get("generated-java").toFile(),
                              Arrays.asList(Paths.get("idl").toFile()));
      }
   }
}
