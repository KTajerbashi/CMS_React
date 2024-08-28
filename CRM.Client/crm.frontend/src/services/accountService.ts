// src/services/accountService.ts
import { get, post, put, del } from "../baseServices/apiService";

export interface Account {
  id: number;
  firstName: string;
  lastName: string;
  emailId: string;
}

function accountService() {
  return {
    get: async (): Promise<Account[]> => {
      return get<Account[]>("Account");
    },
    getById: async (id: number): Promise<Account> => {
      return get<Account>(`Account/${id}`);
    },
    create: async (account: Account): Promise<Account> => {
      return post<Account>("Account", account);
    },
    update: async (id: number, account: Account): Promise<Account> => {
      return put<Account>(`Account/${id}`, account);
    },
    delete: async (id: number): Promise<void> => {
      return del(`Account/${id}`);
    },
  };
}

// Delete an account
const AccountService = accountService();
export default AccountService;
