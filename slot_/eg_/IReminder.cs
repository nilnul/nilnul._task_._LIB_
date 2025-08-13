namespace nilnul.task.slate_.slot_.eg_
{
	/// <summary>
	/// a slot with a trigger, which might trigger a ui:
	///		1) sound
	///		2) display
	///		3) interactive with the user. eg user can cancel or defer the notification.
	///	one the notification is trigger, it's in the realm of the notification app which , not the task app anymore, will handle the subsequent staff.
	/// </summary>
	interface IReminder { }
}
