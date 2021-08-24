touch one.txt
touch two.txt
touch fin.txt

while :; do
	$(tmux capture-pane -t tes3-server -pS 32768 > one.txt)
	output=$(comm -23 <(sort one.txt) <(sort two.txt))
	len=`expr "$output" : '.*'`
	if [ "$len" -gt 0 ]; then
		$(echo "$output" > fin.txt)
		$(cat one.txt > two.txt)
		$(echo 0 > done.d)
	fi
	echo "OUTPUT:\n$output"
	sleep 2
done
