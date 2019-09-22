//Action Adventure game template

function ActionAdventure::onCreate(%this)
{
		//server scripts
	exec("./scripts/server/shapeBase.cs");
	exec("./scripts/server/aiPlayer.cs");
	exec("./scripts/server/camera.cs");
	exec("./scripts/server/commands.cs");
	exec("./scripts/server/player.cs");
	exec("./scripts/server/ActionAdventureGame.cs");

	exec("./scripts/server/spawn.cs");

	//load datablocks right now
	//exec("./scripts/datablocks/sounds.cs");
}

function ActionAdventure::onDestroy(%this)
{}

function ActionAdventure::initServer(%this)
{
	//register datablocks
	%this.registerDatablock("./scripts/datablocks/aiPlayer.cs");
	%this.registerDatablock("./scripts/datablocks/camera.cs");
	%this.registerDatablock("./scripts/datablocks/dust.cs");
	%this.registerDatablock("./scripts/datablocks/markers.cs");
	%this.registerDatablock("./scripts/datablocks/player.cs");
	%this.registerDatablock("./scripts/datablocks/triggers.cs");
}

function ActionAdventure::initClient(%this)
{
   if (!$Server::Dedicated)
   {
      //client scripts
      $KeybindPath = "data/ActionAdventure/scripts/client/default.keybinds.cs";
      exec($KeybindPath);
      
      %prefPath = getPrefpath();
      if(isFile(%prefPath @ "/keybinds.cs"))
         exec(%prefPath @ "/keybinds.cs");
      
      //gui
      //

      exec("data/ActionAdventure/scripts/client/inputCommands.cs");
   }
}