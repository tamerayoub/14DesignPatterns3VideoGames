using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is the Invoker for the Command Pattern, this invokes the command; usually this was help us record the commands we use, but now this isnt much needed
public class Invoker : MonoBehaviour
{
    public void ExecuteCommand(Command aCommand) {
        aCommand.Execute();
    }

}
