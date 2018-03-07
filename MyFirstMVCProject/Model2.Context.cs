﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMVCProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SurveyEntities : DbContext
    {
        public SurveyEntities()
            : base("name=SurveyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Entity1> Entity1 { get; set; }
    
        [EdmFunction("SurveyEntities", "SplitParameterValues")]
        public virtual IQueryable<SplitParameterValues_Result> SplitParameterValues(string inputString, string splitChar)
        {
            var inputStringParameter = inputString != null ?
                new ObjectParameter("InputString", inputString) :
                new ObjectParameter("InputString", typeof(string));
    
            var splitCharParameter = splitChar != null ?
                new ObjectParameter("SplitChar", splitChar) :
                new ObjectParameter("SplitChar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SplitParameterValues_Result>("[SurveyEntities].[SplitParameterValues](@InputString, @SplitChar)", inputStringParameter, splitCharParameter);
        }
    
        public virtual ObjectResult<AllSurveysSelect_Result> AllSurveysSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllSurveysSelect_Result>("AllSurveysSelect");
        }
    
        public virtual ObjectResult<GetAnswersByParticipants_Result> GetAnswersByParticipants()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAnswersByParticipants_Result>("GetAnswersByParticipants");
        }
    
        public virtual ObjectResult<GetDatabyQuestionNm_Result> GetDatabyQuestionNm(string questionNm)
        {
            var questionNmParameter = questionNm != null ?
                new ObjectParameter("QuestionNm", questionNm) :
                new ObjectParameter("QuestionNm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDatabyQuestionNm_Result>("GetDatabyQuestionNm", questionNmParameter);
        }
    
        public virtual ObjectResult<LocationSelect_Result> LocationSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LocationSelect_Result>("LocationSelect");
        }
    
        public virtual ObjectResult<Nullable<int>> SessionInsert(string location, Nullable<System.DateTime> sessionDate, string instructor, string userNm)
        {
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var sessionDateParameter = sessionDate.HasValue ?
                new ObjectParameter("SessionDate", sessionDate) :
                new ObjectParameter("SessionDate", typeof(System.DateTime));
    
            var instructorParameter = instructor != null ?
                new ObjectParameter("Instructor", instructor) :
                new ObjectParameter("Instructor", typeof(string));
    
            var userNmParameter = userNm != null ?
                new ObjectParameter("UserNm", userNm) :
                new ObjectParameter("UserNm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SessionInsert", locationParameter, sessionDateParameter, instructorParameter, userNmParameter);
        }
    
        public virtual ObjectResult<SessionSelect_Result> SessionSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SessionSelect_Result>("SessionSelect");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SurveyInsert(Nullable<int> sessionId, string participantName, Nullable<int> question1, Nullable<int> question2, Nullable<int> question3, Nullable<int> question4, Nullable<int> question5, string question6, string question7, string question8, string question9, string userNm)
        {
            var sessionIdParameter = sessionId.HasValue ?
                new ObjectParameter("SessionId", sessionId) :
                new ObjectParameter("SessionId", typeof(int));
    
            var participantNameParameter = participantName != null ?
                new ObjectParameter("ParticipantName", participantName) :
                new ObjectParameter("ParticipantName", typeof(string));
    
            var question1Parameter = question1.HasValue ?
                new ObjectParameter("Question1", question1) :
                new ObjectParameter("Question1", typeof(int));
    
            var question2Parameter = question2.HasValue ?
                new ObjectParameter("Question2", question2) :
                new ObjectParameter("Question2", typeof(int));
    
            var question3Parameter = question3.HasValue ?
                new ObjectParameter("Question3", question3) :
                new ObjectParameter("Question3", typeof(int));
    
            var question4Parameter = question4.HasValue ?
                new ObjectParameter("Question4", question4) :
                new ObjectParameter("Question4", typeof(int));
    
            var question5Parameter = question5.HasValue ?
                new ObjectParameter("Question5", question5) :
                new ObjectParameter("Question5", typeof(int));
    
            var question6Parameter = question6 != null ?
                new ObjectParameter("Question6", question6) :
                new ObjectParameter("Question6", typeof(string));
    
            var question7Parameter = question7 != null ?
                new ObjectParameter("Question7", question7) :
                new ObjectParameter("Question7", typeof(string));
    
            var question8Parameter = question8 != null ?
                new ObjectParameter("Question8", question8) :
                new ObjectParameter("Question8", typeof(string));
    
            var question9Parameter = question9 != null ?
                new ObjectParameter("Question9", question9) :
                new ObjectParameter("Question9", typeof(string));
    
            var userNmParameter = userNm != null ?
                new ObjectParameter("UserNm", userNm) :
                new ObjectParameter("UserNm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SurveyInsert", sessionIdParameter, participantNameParameter, question1Parameter, question2Parameter, question3Parameter, question4Parameter, question5Parameter, question6Parameter, question7Parameter, question8Parameter, question9Parameter, userNmParameter);
        }
    
        public virtual ObjectResult<string> SurveyQuestionSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SurveyQuestionSelect");
        }
    }
}
