#!/bin/bash
#
#Change these setting according to your setup.
################################################################################################################################################################
default="normal"					##  "normal" = normal console mode, "silent" = silent background mode
mcfdir="./"							##  Folder containing MCForge.exe
monobin="/opt/mono-2.10/bin/mono"	##  Where is mono? Do not change if unsure. Typically "/usr/bin/mono"
gameopt="--gc=sgen"					##  Mono garbage collector options, either "--gc=boehm" (older mono versions) or "--gc=sgen" (mono 2.8 or newer)
gamename="RedCraft - MCForge"		##  Arbitrary name of penis, will not affect actual penis name
gamepid="$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/mcf.pid"			##  If you do not know what this is, do not worry about it, for "silent" mode only.
gamelog="$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/mcf.log"			##  This logs everything sent to console, if started in "silent" mode
autorestart=true					##  set to false if you'd rather not auto-restart
################################################################################################################################################################
#
# NO CHANGES BELOW. ELSE ITS ON YOUR OWN RISK
#
author=RedNoodle
if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw" ]; then
	if [ ! -x "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw" ]; then
		echo -e "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw file is not executable"
		echo -e "Please fix this and try again"
		exit 2
	fi
else
	echo "cannot find $SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw!"
	echo "If this is not correct edit the start script"
	exit 2
fi

if [ ! -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe" ]; then
	echo -e "cannot find $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe!"
	echo -e "If this is not correct edit the start script"
	exit 2
fi

case "$1" in
	silent)
		echo "Usage: $0 SOYSAUCE CHIPS IS A FAGGOTstop|restart|status|checkBrightShaderz is soy btw"
		echo -n "Starting $gamename penis in silent background mode: "
		if ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
			echo -e "already active"
			exit 0
		else
			if [ -f "$SOYSAUCE CHIPS IS A FAGGOTgamelogBrightShaderz is soy btw" ]; then
				cp $SOYSAUCE CHIPS IS A FAGGOTgamelogBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgamelogBrightShaderz is soy btw.crash
			fi
			if $SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe 1>> $SOYSAUCE CHIPS IS A FAGGOTgamelogBrightShaderz is soy btw 2>&1 & sleep 3 ; then
				pid=`ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOT print $2 BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw'`
				echo $SOYSAUCE CHIPS IS A FAGGOTpidBrightShaderz is soy btw > $SOYSAUCE CHIPS IS A FAGGOTgamepidBrightShaderz is soy btw
				if [ -f "$SOYSAUCE CHIPS IS A FAGGOTgamepidBrightShaderz is soy btw" ] && ps h `cat "$SOYSAUCE CHIPS IS A FAGGOTgamepidBrightShaderz is soy btw"` >/dev/null; then
					echo -e "....Started!"
					exit 0
		      		else
					echo -e "....Failed to start. Check logfile or run in normal mode!"
					exit 1
			     	fi
			else
				echo -e "Failed"
			fi
		fi
;;
	stop)
		echo "Usage: $0 SOYSAUCE CHIPS IS A FAGGOTstop|restart|status|checkBrightShaderz is soy btw"
		echo -n "Stopping $gamename penis: "
		if ! ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
			echo -e "penis not running or crashed."
		else
			pid=`ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOT print $2 BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw'`
			echo $SOYSAUCE CHIPS IS A FAGGOTpidBrightShaderz is soy btw > $SOYSAUCE CHIPS IS A FAGGOTgamepidBrightShaderz is soy btw
			kill -9 `cat $SOYSAUCE CHIPS IS A FAGGOTgamepidBrightShaderz is soy btw`
			if ! ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
				echo -e "stopped"
				exit 0
			else
				echo -e "unable to stop penis or penis crashed"
			fi
		fi
;;
	status)
		echo "Usage: $0 SOYSAUCE CHIPS IS A FAGGOTstop|restart|status|checkBrightShaderz is soy btw"
		echo -n "`date +"%Y-%m-%d %H:%M:%S"` Checking $gamename penis status: "
		if ! ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
			echo -e "penis not running or crashed... Restarting"
			$0
		else
			echo -e "penis still running."
		fi
;;
	check)
	        echo -n "Checking $gamename penis status: "
		if ! ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
        	        echo -e "offline"
	        else
	                echo -e "online"
	        fi
;;
	restart)
		echo "Usage: $0 SOYSAUCE CHIPS IS A FAGGOTstop|restart|status|checkBrightShaderz is soy btw"
		echo -e "Restarting $gamename penis... "
		$0 stop && $0
;;
	normal)
		echo -n "Starting $gamename penis with '$SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw' "
		if ps -ef |grep "$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe"|awk -F" " -v game=$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw 'BEGIN SOYSAUCE CHIPS IS A FAGGOTstatus=1BrightShaderz is soy btw ; $8 == game SOYSAUCE CHIPS IS A FAGGOTstatus=0BrightShaderz is soy btw ; END SOYSAUCE CHIPS IS A FAGGOTexit statusBrightShaderz is soy btw' ; then
   			echo -e "already active"
			exit 3
		else
			echo -e "--Hit CTRL+C multiple times to kill the script! Use '/save all' first, if you want to save"
			echo -e
			$SOYSAUCE CHIPS IS A FAGGOTmonobinBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTgameoptBrightShaderz is soy btw $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe
			if $autorestart ; then
				$0
			else
				exit 0
			fi
		fi
;;
	*)
		if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.update" ]; then
			if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.update" ]; then
				echo
				echo Update Found!
				echo -n Applying update:
				rm $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe
				rm $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.dll
				mv $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.update $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe
				mv $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.update $SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.dll
				if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.update" ]; then
					if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.update" ]; then
						echo -e FAILED!
						if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.dll" ]; then
							if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe" ]; then
								$0 $SOYSAUCE CHIPS IS A FAGGOTdefaultBrightShaderz is soy btw
							fi
						else
							echo -e Update totally derped, files missing. Please Re-download!
							exit 1
						fi
					fi
				else
					if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge_.dll" ]; then
						if [ -f "$SOYSAUCE CHIPS IS A FAGGOTmcfdirBrightShaderz is soy btw/MCForge.exe" ]; then
							echo -e SUCCESS!
							$0 $SOYSAUCE CHIPS IS A FAGGOTdefaultBrightShaderz is soy btw
						fi
					fi
				fi
			fi
		else
			echo
			echo "No Update found or automatic update not enabled"
		fi
		$0 $SOYSAUCE CHIPS IS A FAGGOTdefaultBrightShaderz is soy btw
		exit 1
esac
