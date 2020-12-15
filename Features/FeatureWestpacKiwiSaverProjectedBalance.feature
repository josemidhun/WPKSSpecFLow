Feature: FeatureWestpacKiwiSaverProjectedBalance
In order to plan their investments better for the users.
	As a Product Owner
	I want that the KiwiSaver Retirement Calculator users are able to calculate what their KiwiSaver projected balance would be at retirement

@mytag
Scenario: Estimated KiwiSaver Balance
	Given the User Navigate to Westpac KiwiSaver Retirement Calculator Page Calculator Page
	And the User CurrentAge is <CurrentAge>
	And the User Employment Status is <EmploymentStatus>
	And the User Annual Income is <AnnualIncome>
	And the User KiwiSaver Member Contribution is <KiwiSaverMemberContribution>
	And the User Current Kiwi Saver Balance is <CurrentKiwiSaverBalance>
	And the User Voluntary Contributions is <VoluntaryContributions>
    And the User Voluntary Contributions Frequency is <VoluntaryContributionsFrequency>
	And the User Risk Profile is <RiskProfile>
	And the User Savings Goal is <SavingsGoal>
	When the User KiwiSaver projected balance is calculated 
	Then the User can see the estimated KiwiSaver Projected Balance

	Examples: 
	| CurrentAge | EmploymentStatus | AnnualIncome | KiwiSaverMemberContribution | CurrentKiwiSaverBalance | VoluntaryContributions | VoluntaryContributionsFrequency | RiskProfile  | SavingsGoal |
	| 30         | Employed         | 82000        | 4%                          |			               |                        |				                  | Defensive    |    |
	| 45         | Self-employed    |			   |                             |			$100000        |         $90            |		Fortnightly		          | Conservative | $290,000    |
	| 55         | Not employed     |			   |                             |			$140000        |         $10            |		Annually                  | Balanced     | $200,000    |