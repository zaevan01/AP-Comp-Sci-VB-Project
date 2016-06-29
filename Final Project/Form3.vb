Public Class Form3

    'DIMENSION ALL THE THINGS
    Public playerCharacter As Integer
    Dim characterName As String
    Dim foeCharacter As Integer
    Dim foeName As String
    Dim opponentName As String
    Dim eventCount As Integer
    Dim attackCount As Integer
    Dim strikeVariable As Integer
    Dim order As Integer
    Dim foeStrike As New Random
    Dim hitMiss As New Random
    Dim attackOrder As New Random
    Dim playerAttributes(10) As Integer
    Dim foeAttributes(10) As Integer
    Dim foeAttack(3) As Integer
    Dim attackName(4) As String

    'Speed
    'Health
    'Evade
    'attackOneAcc
    'attackOnePwr
    'attackTwoAcc
    'attackTwoPwr
    'attackThreeAcc
    'attackThreePwr
    'attackFourAcc
    'attackFourPwr

    'assigns/resets player stats
    Public Sub playerStats()
        If playerCharacter = 1 Then
            characterName = "Iron Man"
            radAttack1.Text = "Repulsor Beam"
            radAttack2.Text = "Tank Missile"
            radAttack3.Text = "Unibeam"
            radAttack4.Text = "Shoulder Rockets"
            playerAttributes(0) = 250
            playerAttributes(1) = 500
            playerAttributes(2) = 80
            'Repulsor Beam
            playerAttributes(3) = 100
            playerAttributes(4) = 55
            'Tank Missile
            playerAttributes(5) = 80
            playerAttributes(6) = 80
            'Unibeam
            playerAttributes(7) = 90
            playerAttributes(8) = 70
            'Shoulder Rockets
            playerAttributes(9) = 100
            playerAttributes(10) = 60
            pctPlayer.Image = My.Resources.ironMan
        ElseIf playerCharacter = 2 Then
            characterName = "Deadpool"
            radAttack1.Text = "Sword Slash"
            radAttack2.Text = "Pistol Shot"
            radAttack3.Text = "Grenade"
            radAttack4.Text = "Assault Rifle"
            playerAttributes(0) = 300
            playerAttributes(1) = 400
            playerAttributes(2) = 90
            'Sword Slash
            playerAttributes(3) = 100
            playerAttributes(4) = 45
            'Pistol Shot
            playerAttributes(5) = 100
            playerAttributes(6) = 40
            'Grenade
            playerAttributes(7) = 100
            playerAttributes(8) = 70
            'Assault Rifle
            playerAttributes(9) = 100
            playerAttributes(10) = 60
            pctPlayer.Image = My.Resources.deadPool
        ElseIf playerCharacter = 3 Then
            characterName = "Gambit"
            radAttack1.Text = "Staff Strike"
            radAttack2.Text = "Card Throw"
            radAttack3.Text = "Dodge"
            radAttack4.Text = "Staff Charge"
            playerAttributes(0) = 350
            playerAttributes(1) = 350
            playerAttributes(2) = 90
            'Staff Strike
            playerAttributes(3) = 80
            playerAttributes(4) = 60
            'Card Throw
            playerAttributes(5) = 100
            playerAttributes(6) = 50
            'Dodge, raises evasiveness
            playerAttributes(7) = 100
            playerAttributes(8) = 0
            'Staff Charge
            playerAttributes(9) = 70
            playerAttributes(10) = 60
            pctPlayer.Image = My.Resources.gambit
        ElseIf playerCharacter = 4 Then
            characterName = "Luke Cage"
            radAttack1.Text = "Power Punch"
            radAttack2.Text = "Ground Pound"
            radAttack3.Text = "Speed Blitz"
            radAttack4.Text = "Rage Attack"
            playerAttributes(0) = 200
            playerAttributes(1) = 500
            playerAttributes(2) = 60
            'Power Punch
            playerAttributes(3) = 70
            playerAttributes(4) = 70
            'Ground Pound
            playerAttributes(5) = 60
            playerAttributes(6) = 80
            'Speed Blitz
            playerAttributes(7) = 90
            playerAttributes(8) = 60
            'Rage Attack
            playerAttributes(9) = 70
            playerAttributes(10) = 100
            pctPlayer.Image = My.Resources.lukeCage
        ElseIf playerCharacter = 5 Then
            characterName = "Ant Man"
            radAttack1.Text = "Mega Stomp"
            radAttack2.Text = "Minimize"
            radAttack3.Text = "Swarm Attack"
            radAttack4.Text = "Shrink Charge"
            playerAttributes(0) = 250
            playerAttributes(1) = 400
            playerAttributes(2) = 70
            'Mega Stomp
            playerAttributes(3) = 90
            playerAttributes(4) = 70
            'Minimize, raises evasiveness
            playerAttributes(5) = 100
            playerAttributes(6) = 0
            'Swarm Attack
            playerAttributes(7) = 100
            playerAttributes(8) = 60
            'Shrink Charge
            playerAttributes(9) = 100
            playerAttributes(10) = 80
            pctPlayer.Image = My.Resources.antMan
        End If
    End Sub
    'George Washington's stats
    Public Sub georgeWashington()
        foeCharacter = 0
        foeAttributes(0) = 250
        foeAttributes(1) = 300
        foeAttributes(2) = 60

        attackName(1) = "pistols"
        foeAttributes(3) = 100
        foeAttributes(4) = 35

        attackName(2) = "rifle"
        foeAttributes(5) = 90
        foeAttributes(6) = 40

        attackName(3) = "axe"
        foeAttributes(7) = 100
        foeAttributes(8) = 30

        attackName(4) = "knife"
        foeAttributes(9) = 80
        foeAttributes(10) = 55

        foeName = "George Washington"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.georgeWashingtonHeadshot
    End Sub
    'Abe Lincoln's stats
    Public Sub abeLincoln()
        foeCharacter = 1
        foeAttributes(0) = 200
        foeAttributes(1) = 350
        foeAttributes(2) = 70

        attackName(1) = "assault Rifle"
        foeAttributes(3) = 80
        foeAttributes(4) = 50

        attackName(2) = "bear attack"
        foeAttributes(5) = 80
        foeAttributes(6) = 60

        attackName(3) = "bear's lazer eyes"
        foeAttributes(7) = 90
        foeAttributes(8) = 80

        attackName(4) = "bear's sonic growl"
        foeAttributes(9) = 100
        foeAttributes(10) = 70

        foeName = "Abe Lincoln"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.abeLincolnHeadshot
    End Sub
    'Andrew Jackson's stats
    Public Sub andrewJackson()
        foeCharacter = 2
        foeAttributes(0) = 300
        foeAttributes(1) = 350
        foeAttributes(2) = 80

        attackName(1) = "lazer rifle"
        foeAttributes(3) = 100
        foeAttributes(4) = 55

        attackName(2) = "grapling hook"
        foeAttributes(5) = 80
        foeAttributes(6) = 70

        attackName(3) = "broadsword"
        foeAttributes(7) = 90
        foeAttributes(8) = 65

        attackName(4) = "magnum"
        foeAttributes(9) = 100
        foeAttributes(10) = 70

        foeName = "Andrew Jackson"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.andrewJacksonHeadshot
    End Sub
    'Ronald Reagan's stats
    Public Sub ronaldReagan()
        foeCharacter = 3
        foeAttributes(0) = 350
        foeAttributes(1) = 300
        foeAttributes(2) = 90

        attackName(1) = "SMG burst"
        foeAttributes(3) = 80
        foeAttributes(4) = 60

        attackName(2) = "RPG"
        foeAttributes(5) = 90
        foeAttributes(6) = 85

        attackName(3) = "velociraptor"
        foeAttributes(7) = 90
        foeAttributes(8) = 100

        attackName(4) = "knife"
        foeAttributes(9) = 90
        foeAttributes(10) = 50

        foeName = "Ronald Reagan"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.ronaldReaganHeadshot
    End Sub
    'Teddy Roosevelt's stats
    Public Sub teddyRoosevelt()
        foeCharacter = 4
        foeAttributes(0) = 250
        foeAttributes(1) = 450
        foeAttributes(2) = 70

        attackName(1) = "LMG"
        foeAttributes(3) = 80
        foeAttributes(4) = 70

        attackName(2) = "flag spear"
        foeAttributes(5) = 70
        foeAttributes(6) = 60

        attackName(3) = "flame thrower"
        foeAttributes(7) = 100
        foeAttributes(8) = 180

        attackName(4) = "heal"
        foeAttributes(9) = 100
        foeAttributes(10) = 0

        foeName = "Teddy Roosevelt"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.teddyRooseveltHeadshot
    End Sub
    'FDR's stats
    Public Sub franklinRoosevelt()
        foeCharacter = 5
        foeAttributes(0) = 150
        foeAttributes(1) = 600
        foeAttributes(2) = 50

        attackName(1) = "homing rockets"
        foeAttributes(3) = 100
        foeAttributes(4) = 70

        attackName(2) = "rail gun"
        foeAttributes(5) = 90
        foeAttributes(6) = 80

        attackName(3) = "napalm"
        foeAttributes(7) = 100
        foeAttributes(8) = 90

        attackName(4) = "robot stomp"
        foeAttributes(9) = 90
        foeAttributes(10) = 80

        foeName = "Franklin Roosevelt"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.franklinRooseveltHeadshot
    End Sub
    'Bill Clinton's stats
    Public Sub billClinton()
        foeCharacter = 6
        foeAttributes(0) = 300
        foeAttributes(1) = 450
        foeAttributes(2) = 70

        attackName(1) = "full-auto shotgun"
        foeAttributes(3) = 100
        foeAttributes(4) = 70

        attackName(2) = "SMG"
        foeAttributes(5) = 90
        foeAttributes(6) = 65

        attackName(3) = "grenade"
        foeAttributes(7) = 70
        foeAttributes(8) = 80

        attackName(4) = "butt stock"
        foeAttributes(9) = 80
        foeAttributes(10) = 75

        foeName = "Bill Clinton"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.billClintonHeadshot
    End Sub
    'JFK's stats
    Public Sub johnKennedy()
        foeCharacter = 7
        foeAttributes(0) = 350
        foeAttributes(1) = 500
        foeAttributes(2) = 80

        attackName(1) = "lazer horn"
        foeAttributes(3) = 100
        foeAttributes(4) = 70

        attackName(2) = "plasma knife"
        foeAttributes(5) = 100
        foeAttributes(6) = 75

        attackName(3) = "uni-cannon"
        foeAttributes(7) = 80
        foeAttributes(8) = 80

        attackName(4) = "SCIENCE"
        foeAttributes(9) = 100
        foeAttributes(10) = 100

        foeName = "John Kennedy"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = foeAttributes(1)
        pctPres.Image = My.Resources.johnKennedyHeadshot
    End Sub
    'Ben Franklin's stats
    Public Sub benFranklin()
        foeCharacter = 8
        foeName = "Ben Franklin"
        txtOpponentName.Text = foeName
        txtOpponentHealth.Text = ""
        pctPres.Image = My.Resources.benFranklinHeadshot
    End Sub
    'Close the program when the form is closed
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    'Assigns stats for the player based on which character they selected
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        playerStats()
        rtbDialogue.Text = "As you move through a city in ruins, you see a challenger approaching."
        txtPlayerName.Text = characterName
        eventCount = 0
    End Sub
    'Continuously refreshes each person's health
    Private Sub tmrHealthRefresh_Tick(sender As Object, e As EventArgs) Handles tmrHealthRefresh.Tick
        txtPlayerHealth.Text = playerAttributes(1)
        txtOpponentHealth.Text = foeAttributes(1)
        If playerAttributes(1) <= 0 Then
            tmrHealthRefresh.Stop()
            MsgBox("Git Rekt, Son")
            End
        ElseIf foeAttributes(1) <= 0 Then
            btnAttack.Visible = False
            If foeCharacter = 0 Then
                eventCount = 2
                rtbDialogue.Text = "'What? How?! This will not stand.'"
            ElseIf foeCharacter = 1 Then
                eventCount = 11
                rtbDialogue.Text = "'This is unbelievable!'"
            ElseIf foeCharacter = 2 Then
                eventCount = 18
                rtbDialogue.Text = "..."
            ElseIf foeCharacter = 3 Then
                eventCount = 27
                rtbDialogue.Text = "'You won't ruin our plans. We will be victorious.'"
            ElseIf foeCharacter = 4 Then
                eventCount = 34
                rtbDialogue.Text = "'You'll see. Our plans are already falling into place.'"
            ElseIf foeCharacter = 5 Then
                eventCount = 44
                rtbDialogue.Text = "The structure collapses"
            ElseIf foeCharacter = 6 Then
                eventCount = 65
                rtbDialogue.Text = "'NOOOOOO' he screams, falling to his knees."
            ElseIf foeCharacter = 7 Then
                eventCount = 74
                rtbDialogue.Text = "'This is impossible.'"
            End If
            btnContinue.Visible = True
            btnNext.Visible = False
            tmrHealthRefresh.Stop()
            MsgBox("REKT")
        End If
    End Sub
    'The following code polls the radio button group to see if the player has selected an attack 
    'and displays a description in the rich text box next to it
    Private Sub tmrDetailRefresh_Tick(sender As Object, e As EventArgs) Handles tmrDetailRefresh.Tick
        If radAttack1.Checked Then
            If radAttack1.Text = "Repulsor Beam" Then
                rtbInfo.Text = "A quick, highly accurate energy based attack"
            ElseIf radAttack1.Text = "Sword Slash" Then
                rtbInfo.Text = "'They're great for cutting stuff!'"
            ElseIf radAttack1.Text = "Staff Strike" Then
                rtbInfo.Text = "A fairly accurate, ballenced attack"
            ElseIf radAttack1.Text = "Power Punch" Then
                rtbInfo.Text = "A very powerfull attack, has a small chance to miss"
            ElseIf radAttack1.Text = "Mega Stomp" Then
                rtbInfo.Text = "A powerfull attack; Antman grows in size and steps on his foe. Has a very small chance to miss"
            End If
        ElseIf radAttack2.Checked Then
            If radAttack2.Text = "Tank Missile" Then
                rtbInfo.Text = "A powerfull attack that has a small chance to miss"
            ElseIf radAttack2.Text = "Pistol Shot" Then
                rtbInfo.Text = "'Oooooohhh, I wonder how bad these hurt!'"
            ElseIf radAttack2.Text = "Card Throw" Then
                rtbInfo.Text = "Gambit charges an explosive card and throws it at his enemy. Extremely accurate."
            ElseIf radAttack2.Text = "Ground Pound" Then
                rtbInfo.Text = "An extremely powerfull attack with a 60% accuracy."
            ElseIf radAttack2.Text = "Minimize" Then
                rtbInfo.Text = "Increases Antman's evaisiveness"
            End If
        ElseIf radAttack3.Checked Then
            If radAttack3.Text = "Unibeam" Then
                rtbInfo.Text = "A fairly accurate, high powered energy attack"
            ElseIf radAttack3.Text = "Grenade" Then
                rtbInfo.Text = "'Let's play catch. I'll go first!'"
            ElseIf radAttack3.Text = "Dodge" Then
                rtbInfo.Text = "Raises Gambit's evasiveness"
            ElseIf radAttack3.Text = "Speed Blitz" Then
                rtbInfo.Text = "A fairly powerfull attack"
            ElseIf radAttack3.Text = "Swarm Attack" Then
                rtbInfo.Text = "Antman bombards his enemy with a large swarm of poisonous insects"
            End If
        ElseIf radAttack4.Checked Then
            If radAttack4.Text = "Shoulder Rockets" Then
                rtbInfo.Text = "A barrage of small anti personell rockets lauched from shoulder pods"
            ElseIf radAttack4.Text = "Assault Rifle" Then
                rtbInfo.Text = "'Yay! More bullets!'"
            ElseIf radAttack4.Text = "Staff Charge" Then
                rtbInfo.Text = "Gambit charges his staff with explosive energy and charges at his enemy"
            ElseIf radAttack4.Text = "Rage Attack" Then
                rtbInfo.Text = "An extremely powerfull attack that has a 70% accuracy"
            ElseIf radAttack4.Text = "Shrink Charge" Then
                rtbInfo.Text = "Antman shrinks down to microscopic size, charges at his enemy and grows over 100 feet, delivering a devastating blow"
            End If
        End If
    End Sub
    'the protocol for the foe's attack
    Public Sub foeSequence()
        strikeVariable = foeStrike.Next(0, 4)
        If strikeVariable = 0 Then
            If foeAttributes(3) > playerAttributes(2) Then
                playerAttributes(1) -= foeAttributes(4)
                rtbDialogue.Text = foeName & " did " & foeAttributes(4) & " damage with his " & attackName(1)
                'MsgBox("0-1")
            ElseIf foeAttributes(3) = playerAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                playerAttributes(1) -= foeAttributes(4)
                rtbDialogue.Text = foeName & " did " & foeAttributes(4) & " damage with his " & attackName(1)
                'MsgBox("0-2")
            Else
                rtbDialogue.Text = "He missed!"
                'MsgBox("0-3")
            End If
        ElseIf strikeVariable = 1 Then
            If foeAttributes(5) > playerAttributes(2) Then
                playerAttributes(1) -= foeAttributes(6)
                rtbDialogue.Text = foeName & " did " & foeAttributes(6) & " damage with his " & attackName(2)
                'MsgBox("1-1")
            ElseIf foeAttributes(5) = playerAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                playerAttributes(1) -= foeAttributes(6)
                rtbDialogue.Text = foeName & " did " & foeAttributes(6) & " damage with his " & attackName(2)
                'MsgBox("1-2")
            Else
                rtbDialogue.Text = "He missed!"
                'MsgBox("1-3")
            End If
        ElseIf strikeVariable = 2 Then
            If foeAttributes(7) > playerAttributes(2) Then
                playerAttributes(1) -= foeAttributes(8)
                rtbDialogue.Text = foeName & " did " & foeAttributes(8) & " damage with his " & attackName(3)
                'MsgBox("2-1")
            ElseIf foeAttributes(7) = playerAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                playerAttributes(1) -= foeAttributes(8)
                rtbDialogue.Text = foeName & " did " & foeAttributes(8) & " damage with his " & attackName(3)
                'MsgBox("2-2")
            Else
                rtbDialogue.Text = "He missed!"
                'MsgBox("2-3")
            End If
        ElseIf strikeVariable = 3 Then
            If foeCharacter = 4 And foeAttributes(1) < 450 Then
                foeAttributes(1) += 40
                rtbDialogue.Text = foeName & " healed himself"
            ElseIf foeAttributes(9) > playerAttributes(2) Then
                playerAttributes(1) -= foeAttributes(10)
                rtbDialogue.Text = foeName & " did " & foeAttributes(10) & " damage with his " & attackName(4)
                'MsgBox("3-1")
            ElseIf foeAttributes(9) = playerAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                playerAttributes(1) -= foeAttributes(10)
                rtbDialogue.Text = characterName & " took " & foeAttributes(10) & " damage"
                'MsgBox("3-2")
            Else
                rtbDialogue.Text = "He missed!"
                'MsgBox("3-3")
            End If
        End If
    End Sub
    'The protocol for the player's attack
    Public Sub playerSequence()
        If radAttack1.Checked = True Then
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 50
            End If
            If playerAttributes(3) > foeAttributes(2) Then
                foeAttributes(1) -= playerAttributes(4)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(4) & " damage"
            ElseIf playerAttributes(3) = foeAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                foeAttributes(1) -= playerAttributes(4)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(4) & " damage"
            Else
                rtbDialogue.Text = "Near Miss"
            End If
            btnAttack.Visible = False
            attackCount = 2
            btnNext.Visible = True
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 15
            End If
        ElseIf radAttack2.Checked = True Then
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 50
            End If
            If playerCharacter = 5 And playerAttributes(2) < 100 Then
                playerAttributes(2) += 15
                rtbDialogue.Text = characterName & "'s evasiveness rose"
            ElseIf playerAttributes(5) > foeAttributes(2) Then
                foeAttributes(1) -= playerAttributes(6)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(6) & " damage"
            ElseIf playerAttributes(5) = foeAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                foeAttributes(1) -= playerAttributes(6)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(6) & " damage"
            Else
                rtbDialogue.Text = "Near Miss"
            End If
            btnAttack.Visible = False
            attackCount = 2
            btnNext.Visible = True
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 15
            End If
        ElseIf radAttack3.Checked = True Then
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 50
            End If
            If playerCharacter = 3 And playerAttributes(2) < 100 Then
                playerAttributes(2) += 10
                rtbDialogue.Text = characterName & "'s evasiveness rose"
            ElseIf playerAttributes(7) > foeAttributes(2) Then
                foeAttributes(1) -= playerAttributes(8)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(8) & " damage"
            ElseIf playerAttributes(7) = foeAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                foeAttributes(1) -= playerAttributes(8)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(8) & " damage"
            Else
                rtbDialogue.Text = "Near Miss"
            End If
            btnAttack.Visible = False
            attackCount = 2
            btnNext.Visible = True
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 15
            End If
        ElseIf radAttack4.Checked = True Then
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 50
            End If
            If playerAttributes(9) > foeAttributes(2) Then
                foeAttributes(1) -= playerAttributes(10)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(10) & " damage"
            ElseIf playerAttributes(9) = foeAttributes(2) And hitMiss.Next(1, 5) <= 2 Then
                foeAttributes(1) -= playerAttributes(10)
                rtbDialogue.Text = characterName & " dealt " & playerAttributes(10) & " damage"
            Else
                rtbDialogue.Text = "Near Miss"
            End If
            btnAttack.Visible = False
            attackCount = 2
            btnNext.Visible = True
            If playerCharacter = 2 And playerAttributes(1) < 400 Then
                playerAttributes(1) += 15
            End If
        Else
            MsgBox("Please select an attack.")
        End If
    End Sub
    'code to initialize the fight
    Public Sub fightInitialize()
        tmrHealthRefresh.Start()
        rtbDialogue.Text = "Fight!"
        MsgBox("Rek or git rekt")
        order = attackOrder.Next(0, 101)
        If playerAttributes(0) > foeAttributes(0) Then
            attackCount = 1
            btnAttack.Visible = True
        ElseIf playerAttributes(0) = foeAttributes(0) And order < 50 Then
            attackCount = 1
            btnAttack.Visible = True
        Else
            attackCount = 3
            btnNext.Visible = True
        End If
        eventCount = -1
        btnContinue.Visible = False
    End Sub
    'Sets up the fights, controls the progression of the program
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If eventCount = 0 Then
            rtbDialogue.Text = "'I cannot tell a lie, you're about to get your a** handed to you.'"
            eventCount = 1
        ElseIf eventCount = 1 Then
            georgeWashington()
            fightInitialize()
        ElseIf eventCount = 2 Then
            rtbDialogue.Text = "'No matter. This was only the beginning.'"
            eventCount = 3
        ElseIf eventCount = 3 Then
            rtbDialogue.Text = "'My bretheren will make sure you do not live to see tomorrow.'"
            eventCount = 4
        ElseIf eventCount = 4 Then
            playerStats()
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            txtPlayerHealth.Text = playerAttributes(1)
            rtbDialogue.Text = "Before you move on, you take time to patch up your wounds and make repairs to your equipment."
            eventCount = 5
        ElseIf eventCount = 5 Then
            rtbDialogue.Text = "As you manuver through the ruined buildings, you come to the edge of a forest."
            Me.BackgroundImage = My.Resources.forest
            eventCount = 6
        ElseIf eventCount = 6 Then
            rtbDialogue.Text = "You see movement between the trees. The foliage is too dense to make out a detailed shape, so you move in closer to investigate"
            eventCount = 7
        ElseIf eventCount = 7 Then
            rtbDialogue.Text = "'Who goes there!?!' a voice calls out."
            eventCount = 8
        ElseIf eventCount = 8 Then
            rtbDialogue.Text = "You remain silent."
            eventCount = 9
        ElseIf eventCount = 9 Then
            rtbDialogue.Text = "'Very well then!' the voice exclaims, 'I shall emancipate your head from your shoulders.'"
            eventCount = 10
        ElseIf eventCount = 10 Then
            abeLincoln()
            fightInitialize()
        ElseIf eventCount = 11 Then
            rtbDialogue.Text = "'You shall pay for this.'"
            eventCount = 12
        ElseIf eventCount = 12 Then
            rtbDialogue.Text = "You begin to move through the forest. You hear the wind begin to pick up. The sky darkens. Thunder lights up the clouds."
            Me.BackgroundImage = My.Resources.darkForest
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 13
        ElseIf eventCount = 13 Then
            rtbDialogue.Text = "'Turn back,' the trees seem to whisper."
            eventCount = 14
        ElseIf eventCount = 14 Then
            rtbDialogue.Text = "You look up and see movement in the branches above you. Too big to be an animal. You begin to move slightly faster. You haven't yet had a chance to repair your damages from the last fight, and you can't stop moving now."
            eventCount = 15
        ElseIf eventCount = 15 Then
            andrewJackson()
            rtbDialogue.Text = "Suddenly, a man appears before you."
            eventCount = 16
        ElseIf eventCount = 16 Then
            rtbDialogue.Text = "'You shall pay for what you have done. Your meddling will not be tolerated.'"
            eventCount = 17
        ElseIf eventCount = 17 Then
            fightInitialize()
        ElseIf eventCount = 18 Then
            rtbDialogue.Text = "He vanished just as quickly as he appeared."
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 19
        ElseIf eventCount = 19 Then
            rtbDialogue.Text = "You can't be caught off guard like that again. You stop to heal and make repairs."
            playerStats()
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 20
        ElseIf eventCount = 20 Then
            rtbDialogue.Text = "The clouds begin to clear away as you make your way through to the edge of the forest"
            eventCount = 21
        ElseIf eventCount = 21 Then
            rtbDialogue.Text = "You come upon and open field."
            Me.BackgroundImage = My.Resources.openField
            eventCount = 22
        ElseIf eventCount = 22 Then
            rtbDialogue.Text = "You see something off in the distance. As it approaches, you ready yourself for any possibility."
            eventCount = 23
        ElseIf eventCount = 23 Then
            rtbDialogue.Text = "Suddenly, you hear bullets whizzing past your head. You take evasive action in an attempt to avoid damage."
            eventCount = 24
        ElseIf eventCount = 24 Then
            rtbDialogue.Text = "As the figure gets closer, you make out a man. Riding a raptor."
            eventCount = 25
        ElseIf eventCount = 25 Then
            ronaldReagan()
            rtbDialogue.Text = "'I'd like to choose peace, but you've made that impossible.'"
            eventCount = 26
        ElseIf eventCount = 26 Then
            fightInitialize()
        ElseIf eventCount = 27 Then
            rtbDialogue.Text = "You look around. The field is burning."
            Me.BackgroundImage = My.Resources.burningField
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            eventCount = 28
        ElseIf eventCount = 28 Then
            rtbDialogue.Text = "As you sprint through the field, your wounds begin to nag at you."
            eventCount = 29
        ElseIf eventCount = 29 Then
            rtbDialogue.Text = "You come to a lake past the tree line at the other end of the field. You stop on the shore to doctor your wounds."
            Me.BackgroundImage = My.Resources.lakeShore
            playerStats()
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 30
        ElseIf eventCount = 30 Then
            rtbDialogue.Text = "As you patch yourself up, you see the lake begin to bubble."
            eventCount = 31
        ElseIf eventCount = 31 Then
            rtbDialogue.Text = "You look up to see none other than the famous Teddy Roosevelt, rising out of the lake."
            eventCount = 32
        ElseIf eventCount = 32 Then
            teddyRoosevelt()
            rtbDialogue.Text = "'It seems I'm carrying the bigger stick in this situation'"
            eventCount = 33
        ElseIf eventCount = 33 Then
            fightInitialize()
        ElseIf eventCount = 34 Then
            rtbDialogue.Text = "You collapse, exhausted on the sand."
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            eventCount = 35
        ElseIf eventCount = 35 Then
            rtbDialogue.Text = "You repair your wounds."
            playerStats()
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 36
        ElseIf eventCount = 36 Then
            rtbDialogue.Text = "You skirt around the lake as the dead body sinks into the water. You begin wondering what plans these men were referring to. World domination? Terrorism? Your mind begins to wander."
            eventCount = 37
        ElseIf eventCount = 37 Then
            rtbDialogue.Text = "In your absent minded state, you slam your face into a giant metal structure."
            eventCount = 38
        ElseIf eventCount = 38 Then
            rtbDialogue.Text = "The structure begins to rumble."
            eventCount = 39
        ElseIf eventCount = 39 Then
            rtbDialogue.Text = "'YOU' a robotic voice rumbles out."
            eventCount = 40
        ElseIf eventCount = 40 Then
            rtbDialogue.Text = "'You are the one that has been getting in our way!'"
            eventCount = 41
        ElseIf eventCount = 41 Then
            rtbDialogue.Text = "'I will destroy you!'"
            eventCount = 42
        ElseIf eventCount = 42 Then
            rtbDialogue.Text = "'You will know the true meaning of pain'"
            franklinRoosevelt()
            eventCount = 43
        ElseIf eventCount = 43 Then
            fightInitialize()
        ElseIf eventCount = 44 Then
            rtbDialogue.Text = "'So close. I was so close'"
            eventCount = 45
        ElseIf eventCount = 45 Then
            rtbDialogue.Text = "'What?!' you scream, 'what are you planning?!'"
            eventCount = 46
        ElseIf eventCount = 46 Then
            rtbDialogue.Text = "But it's too late. The man inside is dead, and the machine is powered down."
            eventCount = 47
        ElseIf eventCount = 47 Then
            rtbDialogue.Text = "You stand there, confused and slightly panicked."
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            eventCount = 48
        ElseIf eventCount = 48 Then
            rtbDialogue.Text = "'I need to know what they're planning,' you say to yourself, 'I have to stop them.'"
            eventCount = 49
        ElseIf eventCount = 49 Then
            rtbDialogue.Text = "You patch yourself up and begin walking again. You can't remember where or why this journey started, but now it doesn't matter. The only thing taht matters is stopping these people."
            playerStats()
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 50
        ElseIf eventCount = 50 Then
            rtbDialogue.Text = "You suddenly find yourself standing on a cliff, staring down the abyss."
            Me.BackgroundImage = My.Resources.cliff
            eventCount = 51
        ElseIf eventCount = 51 Then
            rtbDialogue.Text = "'I need to find another one of these guys,' you whisper to yourself."
            eventCount = 52
        ElseIf eventCount = 52 Then
            rtbDialogue.Text = "You spoke too soon."
            eventCount = 53
        ElseIf eventCount = 53 Then
            rtbDialogue.Text = "'My fellow American, I'm gonna kill you.'"
            pctPres.Image = My.Resources.barackObamaHeadshot
            txtOpponentName.Text = "Barack Obama"
            eventCount = 54
        ElseIf eventCount = 54 Then
            rtbDialogue.Text = "You punch him square in the nose. His health is immediately reduced to zero."
            eventCount = 55
        ElseIf eventCount = 55 Then
            rtbDialogue.Text = "You grab him by his lapels. 'What are you planning?!' you scream."
            eventCount = 56
        ElseIf eventCount = 56 Then
            rtbDialogue.Text = "'Well, uh,' he stammers, 'ya see, if you keep hitting me like that, I will be forced to tell you.'"
            eventCount = 57
        ElseIf eventCount = 57 Then
            rtbDialogue.Text = "This man seems barely able to think, let alone speak. You punch him in the mouth."
            eventCount = 58
        ElseIf eventCount = 58 Then
            rtbDialogue.Text = "'Speak!' you demand."
            eventCount = 59
        ElseIf eventCount = 59 Then
            rtbDialogue.Text = "'Alright, alright, (inspecific deity's name), I'll talk. We're trying to take control of the moon to hold the earth hostage for ransom.'"
            eventCount = 60
        ElseIf eventCount = 60 Then
            rtbDialogue.Text = "You pull his head and spine completely off, scorpion style."
            eventCount = 61
        ElseIf eventCount = 61 Then
            rtbDialogue.Text = "'Well, that's one less problem I have to worry about,' you mumble to yourself, 'now I just need to get to the moon.'"
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            eventCount = 62
        ElseIf eventCount = 62 Then
            rtbDialogue.Text = "Suddenly, a man appears from over the edge of the cliff."
            billClinton()
            eventCount = 63
        ElseIf eventCount = 63 Then
            rtbDialogue.Text = "'I must be the one to stop you. You can't win.'"
            eventCount = 64
        ElseIf eventCount = 64 Then
            fightInitialize()
        ElseIf eventCount = 65 Then
            rtbDialogue.Text = "You heal yourself as best you can, then you search his dead body. Looking for what you don't know, but you continue looking."
            playerStats()
            txtPlayerHealth.Text = playerAttributes(1)
            eventCount = 66
        ElseIf eventCount = 66 Then
            rtbDialogue.Text = "You come upon a small device, with the words 'Long range teleporter' engraved into it. In his jacket pocket, you find a small face mask, which you take with you."
            eventCount = 67
        ElseIf eventCount = 67 Then
            rtbDialogue.Text = "You come to a realization. This is it. This is your key. This is how you can get to their moon base and stop them. You put on the mask, realizing now that it's and oxygen re-breather. You take out the device. As you look up, you see the sun beginning to set, and the moon coming into view. This is your chance. You push the button."
            eventCount = 68
        ElseIf eventCount = 68 Then
            rtbDialogue.Text = "*bzzzzz* you're teleported thousands of miles away, to the moon's surface. You look around. It's desolate. Except for one man, riding what appears to be a horse."
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            Me.BackgroundImage = My.Resources.moon
            eventCount = 70
        ElseIf eventCount = 70 Then
            rtbDialogue.Text = "He rides over to you. You can see now that he's riding what appears to be a robotic unicorn."
            johnKennedy()
            eventCount = 71
        ElseIf eventCount = 71 Then
            rtbDialogue.Text = "'So, you're the man that's been mucking up my plans, huh?'"
            eventCount = 72
        ElseIf eventCount = 72 Then
            rtbDialogue.Text = "'Well this ends now.'"
            eventCount = 73
        ElseIf eventCount = 73 Then
            fightInitialize()
        ElseIf eventCount = 74 Then
            rtbDialogue.Text = "'I always win.'"
            eventCount = 75
        ElseIf eventCount = 75 Then
            rtbDialogue.Text = "You strike him in the head. It explodes."
            eventCount = 76
        ElseIf eventCount = 76 Then
            rtbDialogue.Text = "It's over. It's finished."
            pctPres.Image = Nothing
            txtOpponentHealth.Text = ""
            txtOpponentName.Text = ""
            eventCount = 77
        ElseIf eventCount = 77 Then
            rtbDialogue.Text = "You take his steed. You find the controls, activating his rocket hooves."
            eventCount = 78
        ElseIf eventCount = 78 Then
            rtbDialogue.Text = "You ride back to earth at 10 times the speed of sound."
            eventCount = 79
        ElseIf eventCount = 79 Then
            rtbDialogue.Text = "You reach earth's atmosphere, descending through the clouds, back to the surface."
            Me.BackgroundImage = My.Resources.clouds
            eventCount = 80
        ElseIf eventCount = 80 Then
            rtbDialogue.Text = "When suddenly, a man flies up into the clouds to meet you."
            eventCount = 81
        ElseIf eventCount = 81 Then
            rtbDialogue.Text = "'You shall pay!' he screams from off in the distance"
            eventCount = 82
        ElseIf eventCount = 82 Then
            rtbDialogue.Text = "He flies up to you. You're now standing face to face."
            eventCount = 83
        ElseIf eventCount = 83 Then
            rtbDialogue.Text = "'You must die.'"
            benFranklin()
            btnAttack.Visible = True
            btnContinue.Visible = False
        End If
    End Sub
    'progresses the attacks based on the click of the "next" button
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        attackCount = 3
    End Sub
    'FIGHT
    'polls the radio button group to determine which attack the player has selected, then deals the corresponding damage
    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        order = attackOrder.Next(1, 101)
        If foeCharacter = 8 And playerCharacter <> 2 Then
            MsgBox("You FOOL! You aren't even worthy to face me.")
            playerAttributes(1) = 0
        ElseIf foeCharacter = 8 And playerCharacter = 2 Then
            rtbDialogue.Text = "'I submit! I am not worthy! You have won!'"
            MsgBox("Game over: You Win!")
            foeAttributes(1) = 0
        Else
            playerSequence()
        End If
    End Sub
    'generates random number to determine the foes attack, then deals the corresponding damage
    Private Sub tmrAttack_Tick(sender As Object, e As EventArgs) Handles tmrAttack.Tick
        If attackCount = 3 Then
            attackCount = 1
            foeSequence()
            radAttack1.Checked = False
            radAttack2.Checked = False
            radAttack3.Checked = False
            radAttack4.Checked = False
            btnAttack.Visible = True
            btnNext.Visible = False
        End If
    End Sub
End Class