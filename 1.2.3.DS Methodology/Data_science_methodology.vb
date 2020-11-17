'DATA SCIENCE METHODOLOGY

1 Understand the question at hand; 
2 Select an analytic approach or method to solve the problem; 
3 Obtain, understand, prepare and model the data. 
The end goal is to move the data scientist to a point where a data model can be built to answer the question.
Remember that the stages of this methodology are iterative! This means that the model can always be improved for as long as the solution 
is needed, regardless of whether the improvements come from constructive feedback, or from examining newly available data sources.

1."Business Understanding"
    What is the problem we are trying to solve? Define the question.
    What is the goal? Organize and plan how to tackle the problem
	“Top-down” approach – first defining a business problem then analyzing the data to find a solution. 
	“Bottom-up” approach – starting with the data, and then coming up with a business problem based on the data.

2."Analytic Approach"
    How can you use data to answer the business question?
    Identify what time of patterns need to be used:
    If the question is to determine probabilities of an action, then a predictive model might be used. 
    If the question is to show relationships, a descriptive approach maybe be required. 
    This would be one that would look at clusters of similar activities based on events and preferences. 
    Statistical analysis applies to problems that require counts. 
    For example if the question requires a yes/no answer, then a classification approach to predicting a response would be suitable. 
    Machine Learning is a field of study that gives computers the ability to learn without being explicitly programmed. 
    Machine Learning can be used to identify relationships and trends in data that might otherwise not be accessible or identified. 
    If the question is to learn about human behavior, then an appropriate response would be to use Clustering Association approaches.

3."Data Requirements"
    What data do you need to answer the question?
    This includes identifying the necessary data content, formats and sources for initial data collection.

4."Data Collection"
    Where is the data coming from (identify all sources) and how will you get it?
    The understanding of what the business wants and needs will determine what data is collected, from what sources, and by what methods.
    Data requirements are revised and decisions are made as to whether or not the collection requires more or less data.
    Once the data ingredients are collected, then in the data collection stage, the data scientist will have a good understanding
    of what they will be working with. Techniques such as descriptive statistics and visualization can be applied to the data set,
    to assess the content, quality, and initial insights about the data. Gaps in data will be identified and plans to either fill 
    or make substitutions will have to be made. 
    It is alright to defer decisions about unavailable data, and attempt to acquire it at a later stage.
    At this stage, if necessary, data scientists and analytics team members can discuss various ways to better manage their data,
    including automating certain processes in the database, so that data collection is easier and faster.          

5."Data Understanding"
    Is the data that you collected representative of the problem solved? 
    Encompasses all activities related to constructing the data set, in this stage we observe/analyze the data.
    Basic statistics: mean, median, min, max, standard deviation. Correlation. 
    Histograms: to understand how values or a variable are distributed, and which sorts of data preparation may be needed 
        to make the variable more useful in a model.
    From the information provided, certain values can be re-coded or perhaps even dropped if necessary, 
    such as when a certain variable has many missing values.
	Understand its content, assess its quality, discover any interesting preliminary insights, determine whether additional data is necessary
	to fill any gaps in the data.

6."Data Preparation"
    What additional work is required to manipulate/transform and work with data?
    Once the data has been collected, it must be transformed into a useable subset unless it is determined that more data is needed. 
    Once a dataset is chosen, it must then be checked for questionable, missing, or ambiguous cases.
	Manipulate the data in right format to be modeled, addressing missing values, corrective invalid inputs, delete duplicates, 
	properly formatting the data.
    Together with data collection and data understanding, data preparation is the most time-consuming phase.
    It can be automated in order to save time. 
    To work effectively with the data, it must be prepared in a way that addresses missing or invalid values and removes duplicates,
    toward ensuring that everything is properly formatted. 
    #Feature engineering is also part of data preparation. It is the process of using domain knowledge of the data to 
    #create features that make the machine learning algorithms work, for ex create new variables with the existing data.

7."Modeling"
    In what way can the data be visualized and get to answer that is required?
	Developing descriptive or predictive (yes/no) models. 
	The data scientist will use a training set for predictive modelling. A training set is a set of historical data in which the outcomes 
	are already known. The training set acts like a gauge to determine if the predictive model needs to be calibrated. 
	In this stage, the data scientist will play around with different algorithms to ensure that the variables in play are actually 
	required. The success of data compilation, preparation and modelling, depends on the understanding of the problem at hand
	and the appropriate analytical approach being taken.
	iterating back to the data preparation stage to redefine some of the other variables, so as to better represent the underlying 
	information and thereby improve the model.
	A statistician calls a false-positive, a type I error, and a false-negative, a type II error.
	
8."Evaluation"
    Does the model used really answer the initial question or does it need to be adjusted?
	Goes hand-in-hand with modeling in a iterative fashion. Ensures data are properly handled and interpreted.
	It allows the quality of the model to be assessed but it is also an opportunity to see if it meets the initial request. 
	First phase: measure phase to ensure the model is working as intended. 
	Second phase: statistical significance test.

9."Deployment"
    Can you put the model into practice?
	While a data science model will provide an answer, the key to making the answer relevant and useful to address 
	the initial question, involves getting the stakeholders familiar with the tool produced.
	Depending on the purpose of the model, it may be rolled out to a limited group of users or in a test environment, 
	to build up confidence in applying the outcome for use across the board. 

10."Feedback"
    Can you get constructive feedback into answering the question?
	Feedback from the users will help to refine the model and assess it for performance and impact. 
	The value of the model will be dependent on successfully incorporating feedback and making adjustments for as long as 
	the solution is required.
	
"Case study": optimize limited budget for health care, hospital readmission is seen as a failure to properly address patience condition
              what is the best way to allocate the resources? 
1. Goal: provide health care without increasing costs; Objectives: review the process to identify inefficiencies
    30% who completed rehab will be readmitted within 5 years -> decision tree model to understand why this occurs
    Defined 4 objectives: predict CHF readmission outcome for patient; predict readmission risk for patient
    understanding the causes of the outcome/risk; easy to understand.

2. For the case study, a decision tree classification model was used to identify the combination of conditions leading 
    to each patient outcome. In this approach, examining the variables in each of the nodes along each path to a leaf, 
    led to a respective threshold value. This means the decision tree classifier provides both the predicted outcome, 
    as well as the likelihood of that outcome, based on the proportion at the dominant outcome, yes or no, in each group. 
    From this information, the analysts can obtain the readmission risk, or the likelihood of a yes for each patient. 
    If the dominant outcome is yes, then the risk is simply the proportion of yes patients in the leaf. If it is no, 
    then the risk is 1 minus the proportion of no patients in the leaf.

3. This included selecting a suitable patient cohort from the health insurance providers member base.
    First, a patient needed to be admitted as in-patient within the provider service area, so they had have
    access to the necessary information. Second, they focused on patients with a primary diagnosis of congestive heart failure
    during one full year. Third, a patient must have had continuous enrollment for at least six months, 
    prior to the primary admission for congestive heart failure, so that complete medical history could be compiled. 
    Congestive heart failure patients who also had been diagnosed as having other significant medical conditions, 
    were excluded from the cohort because those conditions would cause higher-than-average re-admission rates and, 
    thus, could skew the results.
    For a decision tree classification they needed: one record per patience and columns representing the variables in the model.
    To model the readmission outcome, there needed to be data covering all aspects of the patient s clinical history.
    This content would include admissions, primary, secondary, and tertiary diagnoses, procedures, prescriptions, 
    and other services provided either during hospitalization or throughout patient/doctor visits. 
    Thus, a particular patient could have thousands of records, representing all their related attributes. 
    To get to the one record per patient format, the data scientists rolled up the transactional records to the patient level, 
    creating a number of new variables to represent that information. 
    This was a job for the data preparation.

4. In the context of our case study, these can include: demographic, clinical and coverage information of patients, 
    provider information, claims records, as well as pharmaceutical and other information related to all the diagnoses
    of the congestive heart failure patients. For this case study, certain drug information was also needed, 
    but that data source was not yet integrated with the rest of the data sources. This leads to an important point: 
    It is alright to defer decisions about unavailable data, and attempt to acquire it at a later stage. 
    For example, this can even be done after getting some intermediate results from the predictive modeling. 
    If those results suggest that the drug information might be important in obtaining a good model, 
    then the time to try to get it would be invested. As it turned out though, 
    they were able to build a reasonably good model without this drug information.     

5. In order to understand the data related to congestive heart failure admissions, descriptive statistics needed to be run against 
    the data columns that would become variables in the model. First, these statistics included Hearst, univariates, 
    and statistics on each variable, such as mean, median, minimum, maximum, and standard deviation. Second, pairwise correlations 
    were used, to see how closely certain variables were related, and which ones, if any, were very highly correlated, 
    meaning that they would be essentially redundant, thus making only one relevant for modeling. 
    Third, histograms of the variables were examined to understand their distributions.
    Initially, the meaning of congestive heart failure admission was decided on the basis of a primary diagnosis of 
    congestive heart failure. But working through the data understanding stage revealed that the initial definition 
    was not capturing all of the congestive heart failure admissions that were expected, based on clinical experience.
    This meant looping back to the data collection stage and adding secondary and tertiary diagnoses, 
    and building a more comprehensive definition of congestive heart failure admission.

6. First, define congestive heart failure. The next step involved defining the re-admission criteria for the same condition. 
    The timing of events needed to be evaluated in order to define whether a particular congestive heart failure admission 
    was an initial event, which is called an index admission, or a congestive heart failure-related re-admission.
    Next, the records that were in transactional format were aggregated, meaning that the data included multiple records 
    for each patient. Transactional records included professional provider facility claims submitted for physician, laboratory, 
    hospital, and clinical services.
    A given patient could easily have hundreds or even thousands of these records, depending on their clinical history. 
    Then, all the transactional records were aggregated to the patient level, yielding a single record for each patient, 
    as required for the decision-tree classification method that would be used for modeling. As part of the aggregation process, 
    many new columns were created representing the information in the transactions.
    During discussions around data preparation, a literary review on congestive heart failure was also undertaken to see whether 
    any important data elements were overlooked. Aggregating the transactional data at the patient level, meant merging it with 
    the other patient data, including their demographic information, such as age, gender, type of insurance, and so forth.
    The result was the creation of one table containing a single record per patient, with many columns representing the attributes 
    about the patient in his or her clinical history. These columns would be used as variables in the predictive modeling. 
    The data preparation stage resulted in a cohort of 2,343 patients meeting all of the criteria for this case study. 
    The cohort was then split into training and testing sets for building and validating the model, respectively.

7. Parameter tuning to improve the model.
	We are looking for patients with high-risk readmission, so the outcome of interest will be congestive heart failure readmission 
	equals yes. In this first model, overall accuracy in classifying the yes and no outcomes was 85%. 
	This sounds good, but it represents only 45% of the yes. The actual readmissions are correctly classified, meaning that 
	the model is not very accurate.
	For decision tree classification, the best parameter to adjust is the relative cost of misclassified yes and no outcomes.
	When a true, non-readmission is misclassified, and action is taken to reduce that patient risk, the cost of that error 
	is the wasted intervention (type I error or a false-positive).
	But when a true readmission is misclassified, and no action is taken to reduce that risk, then the cost of that error
	is the readmission and all its attended costs, plus the trauma to the patient. This is a type II error, or a false-negative.
	So we can see that the costs of the two different kinds of misclassification errors can be quite different. For this reason, 
	it is reasonable to adjust the relative weights of misclassifying the yes and no outcomes.
	The large number of false-positives, which would recommend unnecessary and costly intervention for patients, 
	who would not have been re-admitted anyway.
	
8. Four models were built with four different relative misclassification costs. Each value of this model-building parameter 
	increases the true-positive rate, or sensitivity, of the accuracy in predicting yes, at the expense of lower accuracy in predicting no
	that is an increasing false-positive rate. 
	The optimal model is the one giving the maximum separation between the blue ROC curve relative to the red base line. 
	"ROC - receiver operating characteristic curve"
	This curve quantifies how well a binary classification model performs, declassifying the yes and no outcomes when some discrimination
	criterion is varied.
	
9. In this scenario, the business people translated the model results so that the clinical staff could understand how to identify 
	high-risk patients and design suitable intervention actions. The goal, of course, was to reduce the likelihood that these patients 
	would be readmitted within 30 days after discharge.
	
10.