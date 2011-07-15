using System;
namespace Genetibase.NuGenHL7.conf.spec.usecase
{
	
	/// <summary> The use case portion of a conformance specification.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class UseCase
	{
		[System.ComponentModel.Browsable(true)]


		virtual public Actor Actor
		{
			get
			{
				return this.actor;
			}
			
			set
			{
				Actor oldActor = this.actor;
				SupportClass.PropertyChangingEventArgs ve85 = new SupportClass.PropertyChangingEventArgs("actor", oldActor, value);


				this.actor = value;
				SupportClass.PropertyChangingEventArgs me85 = new SupportClass.PropertyChangingEventArgs("actor", oldActor, value);


			}
			
		}

		virtual public PreCondition PreCondition
		{
			get
			{
				return this.preCondition;
			}
			
			set
			{
				PreCondition oldPreCondition = this.preCondition;
				SupportClass.PropertyChangingEventArgs ve86 = new SupportClass.PropertyChangingEventArgs("preCondition", oldPreCondition, value);


				this.preCondition = value;
				SupportClass.PropertyChangingEventArgs me86 = new SupportClass.PropertyChangingEventArgs("preCondition", oldPreCondition, value);


			}
			
		}

		virtual public PostCondition PostCondition
		{
			get
			{
				return this.postCondition;
			}
			
			set
			{
				PostCondition oldPostCondition = this.postCondition;
				SupportClass.PropertyChangingEventArgs ve87 = new SupportClass.PropertyChangingEventArgs("postCondition", oldPostCondition, value);


				this.postCondition = value;
				SupportClass.PropertyChangingEventArgs me87 = new SupportClass.PropertyChangingEventArgs("postCondition", oldPostCondition, value);


			}
			
		}

		virtual public EventFlow EventFlow
		{
			get
			{
				return this.eventFlow;
			}
			
			set
			{
				EventFlow oldEventFlow = this.eventFlow;
				SupportClass.PropertyChangingEventArgs ve88 = new SupportClass.PropertyChangingEventArgs("eventFlow", oldEventFlow, value);


				this.eventFlow = value;
				SupportClass.PropertyChangingEventArgs me88 = new SupportClass.PropertyChangingEventArgs("eventFlow", oldEventFlow, value);


			}
			
		}

		virtual public DerivativeEvent DerivativeEvent
		{
			get
			{
				return this.derivativeEvent;
			}
			
			set
			{
				DerivativeEvent oldDerivativeEvent = this.derivativeEvent;
				SupportClass.PropertyChangingEventArgs ve89 = new SupportClass.PropertyChangingEventArgs("derivativeEvent", oldDerivativeEvent, value);


				this.derivativeEvent = value;
				SupportClass.PropertyChangingEventArgs me89 = new SupportClass.PropertyChangingEventArgs("derivativeEvent", oldDerivativeEvent, value);


			}
			
		}
		
		/// <summary>Holds value of property actor. </summary>
		private Actor actor;
		
		/// <summary>Holds value of property preCondition. </summary>
		private PreCondition preCondition;
		
		/// <summary>Holds value of property postCondition. </summary>
		private PostCondition postCondition;
		
		/// <summary>Holds value of property eventFlow. </summary>
		private EventFlow eventFlow;
		
		/// <summary>Holds value of property derivativeEvent. </summary>
		private DerivativeEvent derivativeEvent;
	}
}